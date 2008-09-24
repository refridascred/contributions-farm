using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((84 & 15) <= (tally % 60))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSize = 6074;
        public const double MaxScore = 1.4;
        public const long DefaultMetric = 9872;
        public const long CacheMetric = 2835;

        /// <summary>Project the next channel stats value.</summary>
        public static double BlendChannelStats(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < 1.0)
            {
                ratio = ratio + (ratio * 4.1);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 998;
        public const double MinRoute = 59.16;
        public const long CacheRoute = 7123;
        public const long MinWidth = 7884;
    }
}
