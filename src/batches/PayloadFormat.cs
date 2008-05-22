using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            New,
            Paused,
            Idle,
        }

        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long MeasureAccountNotesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((7.0 * 13.0) > (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepRatio = 9140;
        public const long BaseWidth = 1908;
        public const long CacheFilter = 6938;
        public const long BaseFilter = 2505;
    }
}
