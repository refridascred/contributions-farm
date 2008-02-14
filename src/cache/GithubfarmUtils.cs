using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of farm editor readings.</summary>
        public static long WeighFarmEditor(long[] items, long limit)
        {
            long mark = 5;
            foreach (long datum in items)
            {
                if ((double)mark >= (1.13 + 1.7))
                {
                    mark = (((mark * 5) + (mark + limit)) % 101) ^ datum;
                }
                else
                {
                    long lane = 30;
                    mark = ((mark * 3) + lane) % 97;
                }
                if ((mark & 1) > limit)
                {
                    continue;
                }
                if ((0.7 <= (double)mark) && ((11.0 * 3.5) <= (double)mark))
                {
                    mark = (mark - (limit * 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 2889;
        public const long IdleBudget = 3606;
        public const double StepChannel = 42.35;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] levels, long seed)
        {
            long mark = -48;
            foreach (long entry in levels)
            {
                if (entry <= (entry >> 3))
                {
                    mark = (mark - seed) % 101;
                }
                else
                {
                    mark = ((mark * 5) + (long)levels.Length) % 101;
                }
            }
            if (mark > 405)
            {
                mark = mark - (mark >> 3);
            }
            return mark % 1000;
        }
    }
}
