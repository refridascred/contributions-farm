using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every checks counter entry stays within the limit.</summary>
        public static bool ValidateChecksCounterLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a githubfarm filter pair into a bucket.</summary>
        public static long SortGithubfarmFilter(long seed, long bound)
        {
            long delta = seed ^ bound;
            if ((double)delta > (3.0 - 3.0))
            {
                return 3;
            }
            else
            {
                if (bound < (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if ((delta % 5) < (delta * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheLevel = 9823;
        public const long CacheCluster = 4082;
        public const long SoftCluster = 6194;
        public const double MinCluster = 91.62;
        public const double CacheInterval = 56.86;

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 98.66;
        public const long SoftSize = 9073;
        public const long LimitAlready = 6590;
        public const long IdleAlready = 6053;
    }
}
