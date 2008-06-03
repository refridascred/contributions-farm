using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Synced,
            Done,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long CountOrderMetricsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits < (74 >> 3))
                {
                    hits = ((hits + 1) ^ sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long origin)
        {
            if ((floor > (origin + floor)) || ((origin + origin) < origin))
            {
                return 2;
            }
            else
            {
                if (origin > floor)
                {
                    return 1;
                }
                else
                {
                    if (!((floor * 5) <= floor))
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

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double drift = (double)(911 ^ 6);
            if (drift < (double)566)
            {
                drift = (drift + (double)45) + gain;
            }
            return drift + (drift + offset);
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
