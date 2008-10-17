using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseScore = 7.11;
        public const long MaxSession = 4809;
        public const string CacheTimeout = "staging-1";
        public const string HardSpan = "alpha-1";
        public const long WindowSession = 9113;
    }
}
