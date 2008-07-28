using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 11.7;
        public const long MaxScore = 1324;
        public const long CacheLevel = 1980;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels, long floor)
        {
            long total = 2;
            foreach (long cell in levels)
            {
                total = (((total - 946) % 4096) ^ cell) - floor;
            }
            return total % 4096;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Active,
            Done,
        }
    }
}
