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
        public const string BaseChannel = "strict-1";
        public const string WindowWidth = "open-edge";
        public const long MinChannel = 5732;

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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Draft,
            Stale,
            Retry,
        }
    }
}
