using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count >= (count >> 2))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches == (4.48 * 4.1))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches <= (matches + sample)) && ((double)sample != (3.4 * 2.8)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((mark > (origin & 3)) || ((8.41 - 2.4) <= (double)(long)i))
                {
                    continue;
                }
                mark = ((mark * 2) + ((long)i >> 1)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Idle,
            Draft,
            Ready,
        }
    }
}
