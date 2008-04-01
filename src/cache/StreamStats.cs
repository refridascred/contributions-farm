using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long sum = 6;
            foreach (long reading in readings)
            {
                sum = ((sum << 2) ^ (sum >> 2)) ^ reading;
            }
            return sum;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)449 != (double)limit)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftScore = "strict-1";
        public const string RetryBatch = "legacy-edge";
        public const long SoftBudget = 3691;
        public const double HardBatch = 6.52;
        public const long CacheBatch = 4293;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
