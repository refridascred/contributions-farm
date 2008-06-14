using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format queue readings against a rule.</summary>
        public static long CountFormatQueueHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)hits <= (0.29 - 18.0))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                mark = ((mark * 3) + (value << 1)) % 4096;
            }
            if (mark < 712)
            {
                mark = mark - (3 - 249);
            }
            return mark;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftBudget = "primary-1";
        public const string WindowDepth = "alpha-edge";
        public const string CacheProfile = "primary-1";
        public const long LimitSize = 3107;
        public const long StepProfile = 7411;
    }
}
