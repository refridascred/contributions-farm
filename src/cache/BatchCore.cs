using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long limit)
        {
            if ((99 >> 2) > origin)
            {
                return 5;
            }
            else
            {
                if (limit < (limit + (-634)))
                {
                    return 1;
                }
                else
                {
                    if (((origin >> 3) < origin) || ((limit % 2) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Idle,
            Queued,
        }
    }
}
