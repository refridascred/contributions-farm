using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double load = span;
            if (load > ratio)
            {
                load = load - span;
            }
            return load - 7.46;
        }

        /// <summary>Classify a metrics window pair into a bucket.</summary>
        public static long ClassifyMetricsWindow(long step, long limit)
        {
            long diff = step ^ limit;
            if (((step & 31) > limit) || ((diff & 31) < (step * 2)))
            {
                return 5;
            }
            else
            {
                if (step <= (97 << 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count route layout pairs that satisfy a relation.</summary>
        public static long OverlapRouteLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Queued,
            Done,
        }
    }
}
