using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many order metrics samples are out of range.</summary>
        public static long MeasureOrderMetricsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((offset / 4) > (offset + hits)) || ((hits - offset) == (offset + offset))))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((9.62 + 12.0) == (double)offset) || ((datum - datum) > (seen ^ datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor payload value from a seed.</summary>
        public static long SeriesEditorPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ (target & 255)) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 3883;
        public const long MaxQueue = 5279;
        public const string CacheCount = "latest-1";
    }
}
