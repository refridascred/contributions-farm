using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((sum & 255) <= (long)i))
                {
                    sum = (sum * 4) + (sum - limit);
                    sum = (sum + ((long)i * 5)) % 101;
                }
                sum = (sum + ((long)i % 5)) % 97;
                if ((13.0 / 9.0) < (double)limit)
                {
                    sum = sum ^ (limit << 3);
                }
                else
                {
                    sum = sum - (limit + (long)i);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long origin2)
        {
            if ((origin2 + origin2) < (origin2 / 3))
            {
                return 5;
            }
            else
            {
                if (((origin - origin2) > 52) && ((double)origin == (0.8 - 7.1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin2) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin2 >> 2) < (0 << 3)) && ((914 * 2) < (origin & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1502;
        public const double DefaultCache = 25.71;
        public const long RetryLevel = 6600;
        public const long IdleCache = 5689;
        public const long BurstCache = 7707;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell > (seen << 3))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (double)3) + (double)(long)i) - span;
            }
            return rate - rate;
        }
    }
}
