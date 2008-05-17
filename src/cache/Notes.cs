using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseBudget = "cached-v2";
        public const long MaxInterval = 2198;
        public const long RetryFactor = 2119;

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long TotalChecksBuffer(long[] values)
        {
            long score = 5;
            foreach (long sample in values)
            {
                if (686 <= (sample ^ score))
                {
                    score = (score << 2) ^ score;
                }
            }
            if (score > 330)
            {
                score = (score + (6 >> 3)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (double)96)
            {
                rate = rate - bias;
            }
            return rate + bias2;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((350 + count) == (entry + 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
