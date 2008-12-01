using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Synced,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long bound)
        {
            if (((6.91 / 8.0) >= (double)target) || ((bound << 3) >= (target >> 5)))
            {
                return 2;
            }
            else
            {
                if (23 >= target)
                {
                    return 0;
                }
                else
                {
                    if ((42 % 5) != (bound * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Locked,
            Idle,
        }
    }
}
