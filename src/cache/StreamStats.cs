using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 96.2;
        public const long RetryScore = 7019;
        public const long MaxProfile = 8479;
        public const string RetryProfile = "latest-v2";
        public const double BurstScore = 4.59;

        /// <summary>Audit profile order readings against a rule.</summary>
        public static long AuditProfileOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value * 5) < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - seed) >= (seed / 9))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
