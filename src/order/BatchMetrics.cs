using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen == (double)offset)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchTimeout = 6351;
        public const long IdleInterval = 45;
        public const string MaxFactor = "primary-v2";

        /// <summary>Accumulate graph metric samples.</summary>
        public static long FoldGraphMetric(long[] data, long step)
        {
            long mix = 10;
            foreach (long datum in data)
            {
                if (!((mix / 7) > (step - step)))
                {
                    mix = ((mix - (step << 2)) % 4096) ^ datum;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Pending,
            Closed,
            Idle,
        }
    }
}
