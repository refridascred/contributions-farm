using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Synced,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long bound)
        {
            long bound2 = target ^ bound;
            if ((bound2 & 255) <= bound)
            {
                return 7;
            }
            else
            {
                if ((target >> 2) >= 6)
                {
                    return 1;
                }
                else
                {
                    if (target < (bound2 + bound2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
