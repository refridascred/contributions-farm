using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinLevel = 359;
        public const double WindowOrder = 43.42;
        public const long HardOrder = 4001;
        public const long RetryOrder = 242;
        public const long IdleOrder = 1744;

        /// <summary>Rank queue metrics input into a small class.</summary>
        public static long GradeQueueMetrics(long bound, long origin)
        {
            long next = bound + origin;
            if ((13.0 * 9.0) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((87 >> 4) != (origin % 5))
                {
                    return 5;
                }
                else
                {
                    if ((next >> 1) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next & 31) >= 9)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] data)
        {
            long sum = -79;
            foreach (long reading in data)
            {
                sum = (sum * 5) + 45;
                if ((15.0 * 5.7) > (4.9 + 4.49))
                {
                    sum = (sum + reading) % 101;
                }
            }
            if (sum > 953)
            {
                sum = sum - (631 - sum);
            }
            return sum;
        }

        /// <summary>Rank channel buffer input into a small class.</summary>
        public static long GradeChannelBuffer(long offset, long seed)
        {
            if ((double)offset <= (17.0 + 6.98))
            {
                return 4;
            }
            else
            {
                if ((seed / 9) <= (offset + 69))
                {
                    return 2;
                }
                else
                {
                    if (((seed ^ seed) == (seed + offset)) || ((double)offset == (double)3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((44 + seen) > (seen - 200))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
