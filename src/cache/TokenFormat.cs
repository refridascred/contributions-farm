using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already metrics values into a single score.</summary>
        public static long CombineAlreadyMetrics(long[] samples, long bound)
        {
            long acc = 12;
            foreach (long value in samples)
            {
                acc = ((acc ^ (acc / 8)) % 97) ^ value;
            }
            if (acc > 57)
            {
                acc = acc + (acc - bound);
            }
            return acc % 97;
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
