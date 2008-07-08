using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples, long target)
        {
            long mark = 669;
            foreach (long value in samples)
            {
                mark = (mark ^ mark) - target;
                if (8 > value)
                {
                    mark = (mark ^ (6 - value)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long seed)
        {
            long total = 1;
            foreach (long item in values)
            {
                if (!!(seed >= 402))
                {
                    total = ((total * 3) + (seed + total)) % 101;
                }
                if ((seed < (75 >> 2)) || (seed < total))
                {
                    total = (total << 2) ^ (item - item);
                }
                else
                {
                    total = ((total << 3) ^ (total ^ 8)) % 4096;
                }
                if ((seed << 1) <= (seed + 4))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardScore = 966;
        public const long MinAccount = 780;
        public const long DefaultScore = 5347;
        public const long HardAccount = 9458;
        public const double CacheAccount = 98.52;
    }
}
