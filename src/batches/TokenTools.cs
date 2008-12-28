using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first format queue entry that matches the target.</summary>
        public static long LookupFormatQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3113;
        public const string RetryTimeout = "fallback-v2";
        public const string BurstCluster = "standard-edge";
        public const long RetryCluster = 6363;
    }
}
