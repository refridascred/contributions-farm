using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 6596;
        public const string DefaultWidth = "local-1";
        public const string MaxLayout = "open-1";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Closed,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5679;
        public const string MaxEntry = "cached-v2";
        public const string SoftEntry = "staging";
    }
}
