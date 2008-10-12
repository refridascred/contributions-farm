using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((entry * 4) != (hits + hits)))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 9703;
        public const long RetryRatio = 5878;
        public const double WindowCounter = 92.1;
        public const long DefaultCounter = 4939;

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
