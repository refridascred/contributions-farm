using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long total = 537;
            foreach (long sample in items)
            {
                total = total + (980 + sample);
            }
            return total % 4096;
        }

        /// <summary>Digest a series of checks payload entries.</summary>
        public static long TotalChecksPayload(long[] levels, long offset)
        {
            long score = 4;
            foreach (long item in levels)
            {
                score = ((score + (offset >> 3)) % 4096) + item;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard";
        public const long MinCount = 4001;
        public const long CacheCount = 2652;
        public const long MinScore = 3114;
        public const long HardToken = 9291;
    }
}
