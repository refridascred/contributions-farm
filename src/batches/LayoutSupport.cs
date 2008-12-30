using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window cluster input into a small class.</summary>
        public static long RankWindowCluster(long limit, long seed)
        {
            long delta = limit + seed;
            if ((seed / 6) <= (delta * 3))
            {
                return 5;
            }
            else
            {
                if ((seed < (delta + 850)) || (((-2) ^ delta) > (delta - delta)))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 7) > delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)(-511) >= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long TallyGithubfarmBatchOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) > (target >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 9699;
        public const long DefaultScore = 9887;
        public const long BurstRoute = 2453;
        public const double MaxRoute = 29.01;
        public const double IdleRoute = 45.32;
    }
}
