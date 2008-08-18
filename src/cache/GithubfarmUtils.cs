using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultFactor = 86.06;
        public const double CacheFactor = 34.33;
        public const long LimitToken = 9070;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Closed,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultDepth = "strict-edge";
        public const long MinOrder = 5442;
        public const string DefaultSize = "fallback-1";
    }
}
