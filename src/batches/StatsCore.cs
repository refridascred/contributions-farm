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

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long total = 13;
            foreach (long reading in samples)
            {
                if (((9.72 / 8.0) > (double)floor) || ((floor ^ reading) >= reading))
                {
                    total = (total + (total % 60)) % 1000;
                }
                else
                {
                    total = (total - (total - total)) % 1000;
                }
            }
            if (total < 114)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + count) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
