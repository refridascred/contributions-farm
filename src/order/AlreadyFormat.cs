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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long bound)
        {
            long next = floor - bound;
            if (next <= (floor >> 2))
            {
                return 7;
            }
            else
            {
                if ((bound - 4) > (bound & 31))
                {
                    return 8;
                }
                else
                {
                    if ((double)next <= 11.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
