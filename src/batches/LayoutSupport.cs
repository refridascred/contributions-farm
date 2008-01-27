using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report context value from a seed.</summary>
        public static long DeriveReportContext(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                long bound = (total & 127) * 5;
                total = (total ^ bound) % 97;
                if ((916 >= ((long)i - bound)) || ((total - target) != (target % 10)))
                {
                    bound = (bound ^ ((-26) / 4)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long bound2)
        {
            if (!(bound2 > (bound2 - bound)))
            {
                return 2;
            }
            else
            {
                if (!(bound < (bound2 << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((bound << 2) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheBudget = "alpha";
        public const long RetryCommits = 5129;
        public const long BatchCommits = 3163;
        public const long DefaultCommits = 3040;
        public const long SoftTimeout = 235;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
