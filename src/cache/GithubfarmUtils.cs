using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a schema command pair into a bucket.</summary>
        public static long SortSchemaCommand(long limit, long offset)
        {
            if (((double)offset < (0.72 / 7.0)) && ((double)offset < 9.5))
            {
                return 0;
            }
            else
            {
                if (((62 & 255) <= (offset << 3)) || ((offset >> 1) > (limit % 10)))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 63) > (168 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultFactor = 5657;
        public const string SoftWidth = "strict";
        public const long StepBatch = 435;
        public const long LimitBudget = 4260;
        public const double BaseCount = 71.25;

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9334;
        public const long WindowProfile = 9858;
        public const long StepProfile = 5647;
        public const long CacheBudget = 5281;
    }
}
