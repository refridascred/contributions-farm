using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "staging";
        public const double MinSpan = 29.07;
        public const double MaxRatio = 88.04;
        public const long CacheBatch = 587;

        /// <summary>Measure how many layout entry samples are out of range.</summary>
        public static long MeasureLayoutEntryGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value % 10) < value)
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
