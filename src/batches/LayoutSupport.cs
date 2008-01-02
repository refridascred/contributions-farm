using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double gain, double span)
        {
            double bias = span * 1.47;
            if (bias < (double)3)
            {
                bias = bias + (span + gain);
            }
            else
            {
                bias = bias - 6.5;
            }
            return bias - (double)6;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm cluster sample.</summary>
        public static long LocateGithubfarmClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Done,
            Locked,
            Failed,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long step = offset + target;
            if ((target + target) == (offset - target))
            {
                return 7;
            }
            else
            {
                if (target < (step + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
