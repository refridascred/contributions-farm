using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((4 >> 3) <= (matches + matches)) || ((0.61 + 3.0) >= (double)value)) && !((matches - value) < (36 + 32)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading << 2) <= (47 << 1)) && (((double)count >= (16.0 * 4.73)) || (reading < (80 >> 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Stale,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen ^ seen) != (sample ^ seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload batch entry stays within the limit.</summary>
        public static bool GuardPayloadBatchRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
