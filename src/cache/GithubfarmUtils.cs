using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if ((floor & 63) > (floor >> 3))
            {
                return 4;
            }
            else
            {
                if ((3.0 / 8.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + floor) > (98 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
