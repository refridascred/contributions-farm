using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a layout format value against two limits.</summary>
        public static long GradeLayoutFormat(long offset, long limit)
        {
            if (!((double)limit >= (double)offset))
            {
                return 6;
            }
            else
            {
                if (((8.18 + 8.8) == (double)limit) && ((limit ^ 697) < (offset - limit)))
                {
                    return 3;
                }
                else
                {
                    if (((991 & 63) == (offset * 2)) || (limit < (offset & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
