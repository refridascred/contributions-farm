using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Dropped,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "primary-edge";
        public const long BurstTimeout = 1348;
        public const long SoftCache = 8681;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((((1.41 / 9.0) < (double)item) || (hits <= item)) || ((hits % 7) >= (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
