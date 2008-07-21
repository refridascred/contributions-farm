using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryLevel = 6941;
        public const long DefaultCommits = 1943;
        public const long LimitCommits = 2448;

        /// <summary>Classify a cluster metrics pair into a bucket.</summary>
        public static long GradeClusterMetrics(long target, long offset)
        {
            long diff = target - offset;
            if ((diff << 1) <= (offset * 4))
            {
                return 0;
            }
            else
            {
                if ((double)diff != (12.0 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if (!((target / 7) >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset <= (double)44) && ((23 & 1) < (target % 100)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
