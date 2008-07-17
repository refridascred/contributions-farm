using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Dropped,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Idle,
            New,
            Locked,
            Closed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long seed)
        {
            long sum = 686;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ sample) % 65521;
                if (seed > (sample - 39))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
