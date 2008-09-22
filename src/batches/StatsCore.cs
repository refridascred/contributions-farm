using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Locked,
            Queued,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = (state - (state - origin)) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series, long limit)
        {
            long total = 178;
            foreach (long entry in series)
            {
                if ((total + limit) <= limit)
                {
                    total = (total + (limit << 3)) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long DigestClusterCounter(long[] series)
        {
            long carry = 345;
            foreach (long value in series)
            {
                if ((carry > (carry - value)) || (value > (value ^ carry)))
                {
                    carry = carry ^ (752 >> 4);
                }
                carry = (carry - (carry & 7)) % 101;
            }
            return carry % 4096;
        }
    }
}
