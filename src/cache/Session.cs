using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Paused,
            Stale,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
