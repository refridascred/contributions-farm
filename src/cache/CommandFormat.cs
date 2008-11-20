using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 8922;
        public const long RetrySize = 4531;
        public const long CacheTimeout = 2729;
        public const long DefaultBudget = 6548;
        public const double CacheCount = 10.27;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a githubfarm batch pair into a bucket.</summary>
        public static long GradeGithubfarmBatch(long step, long bound)
        {
            if ((bound / 6) != (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((538 - step) <= (bound + step))
                {
                    return 2;
                }
                else
                {
                    if ((bound + step) == (step + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((10.0 * 9.0) >= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
