using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen < 3.5)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((5.19 * 5.8) != (double)entry)
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long carry = 22;
            foreach (long value in series)
            {
                if ((value + carry) < value)
                {
                    carry = carry - (7 << 3);
                }
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryScore = 4628;
        public const double SoftEditor = 96.61;
        public const long WindowRatio = 7418;
        public const long DefaultEditor = 486;
        public const long HardRatio = 9569;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
