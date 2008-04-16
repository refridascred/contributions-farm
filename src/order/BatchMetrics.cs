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

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                if (((-4) ^ reading) < (40 - 88))
                {
                    result = (result << 2) ^ (190 * 2);
                }
                else
                {
                    result = ((result << 3) ^ result) % 97;
                }
            }
            return result;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count % 7) <= (entry ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Closed,
            Pending,
            Stale,
            Failed,
        }
    }
}
