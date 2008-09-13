using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Stale,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 39.6;
        public const long RetryCount = 54;
        public const string HardScore = "local-v2";
        public const string CacheChannel = "standard-1";
    }
}
