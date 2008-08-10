using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long step)
        {
            if ((3.3 * 9.0) >= (double)offset)
            {
                return 4;
            }
            else
            {
                if (offset <= ((-551) - offset))
                {
                    return 6;
                }
                else
                {
                    if (step >= (867 & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Draft,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
