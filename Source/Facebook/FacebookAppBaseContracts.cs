﻿// --------------------------------
// <copyright file="FacebookAppBaseContracts.cs" company="Facebook C# SDK">
//     Microsoft Public License (Ms-PL)
// </copyright>
// <author>Nathan Totten (ntotten.com) and Jim Zimmerman (jimzimmerman.com)</author>
// <license>Released under the terms of the Microsoft Public License (Ms-PL)</license>
// <website>http://facebooksdk.codeplex.com</website>
// ---------------------------------

namespace Facebook
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

#pragma warning disable 1591

    /// <summary>
    /// Represents the inheritable contracts for the <see cref="FacebookAppBase"/> class.
    /// </summary>
    [ContractClassFor(typeof(FacebookAppBase))]
    internal abstract class FacebookAppBaseContracts : FacebookAppBase
    {
#if !SILVERLIGHT

        /// <summary>
        /// Invoke the old restserver.php endpoint.
        /// </summary>
        /// <param name="parameters">The parameters for the server call.</param>
        /// <param name="httpMethod">The http method for the request.</param>
        /// <returns>The decoded response object.</returns>
        protected override object RestServer(IDictionary<string, object> parameters, HttpMethod httpMethod, Type resultType)
        {
            Contract.Requires(parameters != null);
            Contract.Requires(parameters.ContainsKey("method") && !String.IsNullOrEmpty((string)parameters["method"]));
            Contract.Ensures(Contract.Result<object>() != null);

            return default(object);
        }

        /// <summary>
        /// Invoke the Graph API.
        /// </summary>
        /// <param name="path">The path of the url to call such as 'me/friends'.</param>
        /// <param name="parameters">object of url parameters.</param>
        /// <param name="httpMethod">The http method for the request.</param>
        /// <returns>
        /// A dynamic object with the resulting data.
        /// </returns>
        /// <exception cref="Facebook.FacebookApiException"/>
        protected override object Graph(string path, IDictionary<string, object> parameters, HttpMethod httpMethod, Type resultType)
        {
            Contract.Requires(!(String.IsNullOrEmpty(path) && parameters == null));

            return default(object);
        }

        /// <summary>
        /// Make a OAuth Request
        /// </summary>
        /// <param name="uri">The url to make the request.</param>
        /// <param name="parameters">The parameters of the request.</param>
        /// <param name="httpMethod">The http method for the request.</param>
        /// <returns>The decoded response object.</returns>
        /// <exception cref="Facebook.FacebookApiException"/>
        protected override object OAuthRequest(Uri uri, IDictionary<string, object> parameters, HttpMethod httpMethod, Type resultType, bool restApi)
        {
            Contract.Requires(uri != null);

            return default(object);
        }
#endif
        /// <summary>
        /// Invoke the old restserver.php endpoint.
        /// </summary>
        /// <param name="callback">The async callback.</param>
        /// <param name="state">The async state.</param>
        /// <param name="parameters">The parameters for the server call.</param>
        /// <param name="httpMethod">The http method for the request.</param>
        protected override void RestServerAsync(IDictionary<string, object> parameters, HttpMethod httpMethod, Type resultType, FacebookAsyncCallback callback, object state)
        {
            Contract.Requires(callback != null);
            Contract.Requires(parameters != null);
            Contract.Requires(parameters.ContainsKey("method") && !String.IsNullOrEmpty((string)parameters["method"]));
        }

        /// <summary>
        /// Invoke the Graph API.
        /// </summary>
        /// <param name="callback">The async callback.</param>
        /// <param name="state">The async state.</param>
        /// <param name="path">The path of the url to call such as 'me/friends'.</param>
        /// <param name="parameters">object of url parameters.</param>
        /// <param name="httpMethod">The http method for the request.</param>
        /// <exception cref="Facebook.FacebookApiException"/>
        protected override void GraphAsync(string path, IDictionary<string, object> parameters, HttpMethod httpMethod, Type resultType, FacebookAsyncCallback callback, object state)
        {
            Contract.Requires(callback != null);
            Contract.Requires(!(String.IsNullOrEmpty(path) && parameters == null));
        }

        /// <summary>
        /// Make a OAuth Request
        /// </summary>
        /// <param name="callback">The async callback.</param>
        /// <param name="state">The async state.</param>
        /// <param name="uri">The url to make the request.</param>
        /// <param name="parameters">The parameters of the request.</param>
        /// <param name="httpMethod">The http method for the request.</param>
        /// <exception cref="Facebook.FacebookApiException"/>
        protected override void OAuthRequestAsync(Uri uri, IDictionary<string, object> parameters, HttpMethod httpMethod, Type resultType, bool restApi, FacebookAsyncCallback callback, object state)
        {
            Contract.Requires(callback != null);
            Contract.Requires(uri != null);
        }
    }
#pragma warning restore 1591
}
