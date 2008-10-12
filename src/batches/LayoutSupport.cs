using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum < (hits - datum))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "cached";
        public const string BurstSpan = "latest";
        public const long BatchScore = 2133;
        public const long DefaultCommand = 7645;

        /// <summary>Adjust a stream context reading.</summary>
        public static double SmoothStreamContext(double scale, double offset)
        {
            double weight = (double)(39 << 3);
            if (weight > (4.7 - offset))
            {
                weight = weight + (weight - 4.1);
            }
            return weight - (scale / 3.0);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long floor)
        {
            if (floor < (floor / 2))
            {
                return 5;
            }
            else
            {
                if ((floor >= (4 ^ floor)) && ((914 & 7) != (floor - bound)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
