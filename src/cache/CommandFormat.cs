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

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long limit)
        {
            long edge = step - limit;
            if (((double)edge < 15.0) || ((limit + 2) < (edge * 5)))
            {
                return 5;
            }
            else
            {
                if (!((51 ^ limit) == (edge + 740)))
                {
                    return 6;
                }
                else
                {
                    if (!(limit <= (limit & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

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
