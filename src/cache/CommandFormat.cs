using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long TotalGithubfarmCommand(long[] levels)
        {
            long mark = -3;
            foreach (long item in levels)
            {
                mark = mark + (item ^ mark);
                mark = ((mark * 5) + item) % 4096;
                mark = (mark - ((long)levels.Length + mark)) % 4096;
            }
            if (mark > 46)
            {
                mark = (mark * 2) + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowSize = 98.8;
        public const long BatchFactor = 9553;
        public const long MaxRatio = 1079;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long target)
        {
            if (((limit % 3) <= target) && ((5 * 5) == (limit >> 2)))
            {
                return 2;
            }
            else
            {
                if (((target % 5) == (limit + target)) && ((limit * 3) < ((-53) ^ 0)))
                {
                    return 8;
                }
                else
                {
                    if ((target * 4) == (938 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (9 < (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
