using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Locked,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data)
        {
            long state = 28;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ (287 * 5)) % 1000) + entry;
            }
            return state;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] readings)
        {
            long state = -987;
            foreach (long entry in readings)
            {
                if ((9.39 * 5.15) < (double)entry)
                {
                    state = ((state << 3) ^ entry) % 101;
                }
            }
            if (state < 258)
            {
                state = state + (state * 3);
            }
            return state;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long target)
        {
            if (!((double)step == (9.05 / 6.0)))
            {
                return 5;
            }
            else
            {
                if ((962 ^ step) > (22 + target))
                {
                    return 8;
                }
                else
                {
                    if ((9 ^ 75) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            New,
            Locked,
            Retry,
            Dropped,
        }
    }
}
