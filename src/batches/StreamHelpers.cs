using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long mix = 373;
            foreach (long item in items)
            {
                if ((item - item) < (366 >> 1))
                {
                    mix = mix - ((-3) % 97);
                }
                else
                {
                    mix = mix - (item + mix);
                }
                if ((item / 2) >= (mix * 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 11.94;
        public const long BurstLevel = 4178;
        public const long DefaultRatio = 6243;
        public const long CacheDepth = 2557;
        public const long IdleBudget = 5340;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
