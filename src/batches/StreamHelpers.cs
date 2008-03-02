using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long offset)
        {
            if ((11.0 / 3.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)(-16) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5656;
        public const double DefaultScore = 75.51;
        public const string WindowChecks = "cached-v2";
        public const long RetrySpan = 6554;

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if (1 > (carry << 1))
                {
                    carry = (((carry << 3) ^ (floor - carry)) % 4096) - entry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine layout queue values into a single score.</summary>
        public static long FoldLayoutQueue(long[] items, long seed)
        {
            long acc = 8;
            foreach (long item in items)
            {
                acc = ((acc + (seed >> 3)) % 4096) + item;
            }
            if (acc > 483)
            {
                acc = (acc ^ (986 << 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a batches counter reading.</summary>
        public static double BlendBatchesCounter(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 - 1.2) + span;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public bool Count { get; set; }
        }
    }
}
