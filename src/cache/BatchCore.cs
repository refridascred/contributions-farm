using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate entry order samples.</summary>
        public static long TotalEntryOrder(long[] items)
        {
            long mix = 734;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix - (mix << 1)) % 65521) - (long)i;
                    mix = (mix + (mix + value)) % 255;
                }
                if (value <= (value << 1))
                {
                    mix = ((mix * 2) + 9) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Dropped,
            Synced,
            New,
            Closed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (7.4 < (double)seed)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
