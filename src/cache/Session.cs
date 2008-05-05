using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a order cache pair into a bucket.</summary>
        public static long RankOrderCache(long target, long origin)
        {
            long next = target - origin;
            if ((origin + origin) != (next % 97))
            {
                return 1;
            }
            else
            {
                if ((next - next) <= (origin + target))
                {
                    return 2;
                }
                else
                {
                    if ((target / 5) >= (next - next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double scale = ratio;
            if (scale < 1.47)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (span - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)(-61);
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
