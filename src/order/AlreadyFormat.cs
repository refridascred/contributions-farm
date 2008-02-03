using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two metric commits measurements.</summary>
        public static double BlendMetricCommits(double gain, double floor)
        {
            double ratio = gain + (double)301;
            if (ratio <= floor)
            {
                ratio = ratio + (double)276;
            }
            else
            {
                ratio = ratio - (ratio - gain);
            }
            return ratio - ratio;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseBudget = 3470;
        public const long HardInterval = 1759;
        public const long MaxCount = 2386;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metrics order samples.</summary>
        public static long ScoreMetricsOrder(long[] values, long origin)
        {
            long anchor = 4;
            foreach (long sample in values)
            {
                anchor = (((anchor << 3) ^ (anchor & 127)) - sample) + origin;
            }
            return anchor % 4096;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long floor)
        {
            long acc = 850;
            foreach (long sample in series)
            {
                if (((sample - floor) <= sample) && ((double)sample > (9.98 + 2.8)))
                {
                    acc = (acc ^ (acc % 60)) % 1000;
                }
                if ((((-29) >> 4) > sample) && ((16.0 / 6.0) == (double)acc))
                {
                    acc = (acc + (sample >> 2)) % 255;
                }
                else
                {
                    acc = (acc + (sample << 3)) % 97;
                }
            }
            if (acc > 618)
            {
                acc = (acc - (acc % 100)) % 1000;
            }
            return acc;
        }
    }
}
