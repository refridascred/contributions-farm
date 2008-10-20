using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] series, long bound)
        {
            long score = 3;
            foreach (long entry in series)
            {
                if ((8 % 60) < (entry & 255))
                {
                    score = ((score << 2) ^ entry) - bound;
                }
            }
            return score % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftBudget = 1806;
        public const double BatchCommits = 36.95;
        public const long HardScore = 7372;
        public const long WindowInterval = 2271;
        public const long BatchBudget = 624;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((820 * 4) < tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
