using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long target, long floor)
        {
            long next = target - floor;
            if (((5.48 / 6.0) > (double)next) && ((next >> 4) <= floor))
            {
                return 0;
            }
            else
            {
                if ((target & 31) >= (floor - next))
                {
                    return 6;
                }
                else
                {
                    if ((350 + floor) < (target - 6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)next != (8.0 - 7.2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Stale,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Dropped,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
