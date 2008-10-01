using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Dropped,
            Pending,
            New,
            Closed,
        }

        /// <summary>Check that every route githubfarm entry stays within the limit.</summary>
        public static bool GuardRouteGithubfarmLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long bound)
        {
            long delta = origin - bound;
            if ((origin + delta) <= (delta / 6))
            {
                return 6;
            }
            else
            {
                if (!(((-1) ^ origin) <= (bound & 15)))
                {
                    return 4;
                }
                else
                {
                    if (((15.0 * 6.24) < (double)delta) || ((bound << 2) < (origin % 60)))
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

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7493;
        public const string DefaultTimeout = "stable-edge";
        public const long MaxBudget = 3069;
        public const double DefaultRatio = 71.74;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long bound)
        {
            long bound2 = offset + bound;
            if ((2.2 + 9.88) >= (double)bound2)
            {
                return 5;
            }
            else
            {
                if (875 >= bound2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
