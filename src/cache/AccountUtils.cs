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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 70.22;
        public const long MinInterval = 1320;
        public const long RetryContributi = 2219;
        public const long MaxContributi = 9486;
        public const double WindowSpan = 83.95;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
