using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a window account value against two limits.</summary>
        public static long BucketWindowAccount(long offset, long limit)
        {
            if ((double)0 >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((4.19 / 7.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((3.4 + 5.66) < (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long state = -80;
            foreach (long entry in data)
            {
                state = (state * 5) + ((long)data.Length ^ entry);
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitRatio = 21.33;
        public const string WindowFactor = "stable-edge";
        public const long MinSpan = 9835;
    }
}
