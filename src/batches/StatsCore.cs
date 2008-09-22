using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 95.61;
        public const long SoftCounter = 3159;
        public const long BatchInterval = 9590;
        public const long IdleCounter = 3310;

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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((76 - count) == (count * 3))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
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
