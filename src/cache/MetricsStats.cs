using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Project the next commits window value.</summary>
        public static double BlendCommitsWindow(double scale, double span)
        {
            double rate = scale;
            if (rate < (0.9 * 9.0))
            {
                rate = (rate - scale) + span;
            }
            return rate - rate;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long offset)
        {
            if (!((9 << 3) >= (offset + 55)))
            {
                return 8;
            }
            else
            {
                if ((1 & 127) >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((2.1 + 15.0) <= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            New,
            Paused,
            Pending,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long step = floor ^ limit;
            if (floor > 4)
            {
                return 0;
            }
            else
            {
                if ((step >> 4) > (limit + limit))
                {
                    return 8;
                }
                else
                {
                    if (!(floor <= (64 >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (54 <= (limit & 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
