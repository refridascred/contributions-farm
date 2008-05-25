using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseRatio = 6.17;
        public const string BaseInterval = "alpha-v2";
        public const long MaxMetrics = 127;
        public const double RetryFactor = 98.75;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long limit)
        {
            if ((76 << 2) == (limit + limit))
            {
                return 8;
            }
            else
            {
                if (floor <= (floor + limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit >= (18.0 + 6.2)) || ((limit ^ 18) != (limit & 127)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((187 ^ limit) > (limit + (-6))) || (limit >= (limit / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long target)
        {
            long total = 26;
            foreach (long sample in items)
            {
                if ((target % 64) < target)
                {
                    total = (total - target) - sample;
                }
                else
                {
                    total = (total << 2) ^ 72;
                }
            }
            return total % 97;
        }
    }
}
