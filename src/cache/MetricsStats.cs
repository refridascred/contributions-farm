using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (floor <= (value + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4855;
        public const long StepBudget = 6618;
        public const long StepCounter = 2013;
        public const long DefaultCounter = 5169;
        public const long BaseSpan = 3510;

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double gain = bias;
            if (gain < scale)
            {
                gain = gain + scale;
            }
            return gain + (bias / 7.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 3146;
        public const string HardBatches = "primary-v2";
        public const double BaseBatches = 48.84;
        public const long BatchWidth = 9403;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long offset)
        {
            long mark = -926;
            foreach (long value in series)
            {
                mark = ((mark << 3) ^ offset) + value;
            }
            if (mark < 9)
            {
                mark = (mark + (offset & 127)) % 1000;
            }
            return mark;
        }
    }
}
