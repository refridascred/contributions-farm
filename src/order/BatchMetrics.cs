using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitBudget = 6039;
        public const long BatchBudget = 1096;
        public const string RetrySize = "alpha-v2";
        public const long BurstSize = 8730;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (seen % 12)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long offset2)
        {
            long edge = offset + offset2;
            if (!((double)offset == (double)offset2))
            {
                return 6;
            }
            else
            {
                if (((double)edge <= (7.0 + 16.0)) && (offset > (edge - offset)))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 & 255) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long offset)
        {
            if ((27 << 2) > (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((offset < ((-631) + offset)) && ((63 << 1) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 5296;
        public const long StepTimeout = 373;
        public const long WindowBudget = 4477;
        public const long BaseFactor = 3011;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
