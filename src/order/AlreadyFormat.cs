using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Stale,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((5.0 + 8.9) == (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long step)
        {
            long offset = limit ^ step;
            if ((limit % 3) <= (limit & 255))
            {
                return 0;
            }
            else
            {
                if (((double)631 >= (double)offset) || ((64 + step) >= step))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
