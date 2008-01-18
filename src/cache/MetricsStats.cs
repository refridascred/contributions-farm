using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Synced,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Match up channel entry samples.</summary>
        public static long MatchChannelEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Stale,
            New,
            Idle,
            Paused,
        }
    }
}
