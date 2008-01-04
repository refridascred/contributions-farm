using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long limit)
        {
            if (78 >= (offset / 9))
            {
                return 4;
            }
            else
            {
                if ((double)limit > 7.9)
                {
                    return 6;
                }
                else
                {
                    if ((7.2 - 6.0) >= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long limit)
        {
            long score = -1;
            foreach (long value in items)
            {
                score = ((score - (score / 3)) + value) - limit;
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
