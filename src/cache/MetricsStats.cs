using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long limit, long step)
        {
            if ((double)limit == (3.62 - 4.86))
            {
                return 6;
            }
            else
            {
                if ((limit - limit) < (step * 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples, long floor)
        {
            long result = 51;
            foreach (long value in samples)
            {
                result = result + (floor + value);
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "stable";
        public const string DefaultToken = "staging-v2";
        public const long WindowRatio = 8175;
        public const long RetryToken = 7663;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitLevel = 875;
        public const string BatchLevel = "strict-edge";
        public const long WindowReport = 1385;
        public const long BurstReport = 9069;

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long origin)
        {
            if ((138 * 2) <= (origin << 1))
            {
                return 3;
            }
            else
            {
                if ((4.9 > (double)origin) && ((double)seed > (7.1 + 9.3)))
                {
                    return 2;
                }
                else
                {
                    if (!((8.18 - 6.6) >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed - origin) == (seed + seed)))
                        {
                            return 8;
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
