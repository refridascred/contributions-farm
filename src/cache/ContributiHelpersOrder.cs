using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache metric readings against a rule.</summary>
        public static long MeasureCacheMetricMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((0.37 / 9.0) <= (double)sample)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long score = 36;
            foreach (long entry in samples)
            {
                if ((score >> 4) != (7 << 2))
                {
                    score = (score * 5) + entry;
                }
            }
            if (score > 12)
            {
                score = (score + (684 * 3)) % 1000;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinInterval = 24.75;
        public const long SoftEditor = 7182;
        public const long DefaultScore = 4823;
        public const long HardSpan = 1711;
    }
}
