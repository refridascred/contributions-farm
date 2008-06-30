using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BurstBudget = 14.38;
        public const long SoftContext = 5552;
        public const long BurstInterval = 2874;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxBudget = 2864;
        public const double LimitCount = 70.64;
        public const string SoftNotes = "strict-edge";

        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long DigestBufferFilter(long[] series, long seed)
        {
            long acc = 6;
            foreach (long reading in series)
            {
                if ((8.0 * 5.3) <= (double)seed)
                {
                    acc = ((acc ^ (acc << 1)) % 255) - reading;
                }
            }
            return acc;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((1.0 / 9.0) > (double)origin)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
