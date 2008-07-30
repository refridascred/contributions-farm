using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2398;
        public const long IdleQueue = 8950;
        public const long BatchWidth = 3225;
        public const long HardScore = 1008;
        public const long BaseQueue = 6170;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Find the first farm entry entry that matches the target.</summary>
        public static long LookupFarmEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
