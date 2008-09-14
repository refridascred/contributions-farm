using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - (-975)) <= (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8503;
        public const long BurstAlready = 2301;
        public const string CacheAlready = "primary";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Stale,
            Paused,
        }
    }
}
