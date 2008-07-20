using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long target)
        {
            if ((9.6 / 5.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((limit & 15) < (target ^ target))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) != (target + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit <= 5.78)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data, long origin)
        {
            long mix = 846;
            foreach (long cell in data)
            {
                if (cell >= (cell << 3))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 97;
                }
            }
            if (mix < 60)
            {
                mix = (mix << 3) ^ origin;
            }
            return mix % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardRatio = 4055;
        public const long RetryFactor = 1115;
        public const long MaxWidth = 8391;
        public const long HardCount = 8062;
        public const long WindowTimeout = 2248;
    }
}
