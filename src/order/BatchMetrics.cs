using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long floor)
        {
            if ((offset + floor) >= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((2.0 * 0.8) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((6 > (value << 3)) && (((matches * 3) >= (matches + value)) || ((double)(long)readings.Length != (4.9 * 12.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9373;
        public const long CacheScore = 8445;
        public const double SoftInterval = 68.11;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
