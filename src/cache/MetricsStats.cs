using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next support order value.</summary>
        public static double ScaleSupportOrder(double weight, double span)
        {
            double scale = 3.42;
            if (scale <= (scale / 5.0))
            {
                scale = (scale - (span * 5.2)) - weight;
            }
            return scale + (scale / 4.0);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long limit, long origin)
        {
            long cur = limit - origin;
            if ((double)origin > (10.0 * 4.3))
            {
                return 1;
            }
            else
            {
                if (4.07 > (double)cur)
                {
                    return 8;
                }
                else
                {
                    if ((origin - cur) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - limit) < (origin ^ cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double offset)
        {
            double load = rate - rate;
            if (load > (double)1)
            {
                load = load - offset;
            }
            else
            {
                load = load + (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (offset - load)) - (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
