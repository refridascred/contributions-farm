using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long seed)
        {
            if ((double)bound <= (3.0 / 4.0))
            {
                return 8;
            }
            else
            {
                if (((seed & 15) >= (bound << 2)) && ((seed * 5) == (seed - bound)))
                {
                    return 1;
                }
                else
                {
                    if (((669 & 15) < bound) || ((seed + bound) <= (1 - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading - reading) >= hits)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings)
        {
            long sum = 596;
            foreach (long datum in readings)
            {
                if ((double)sum < (18.0 - 4.0))
                {
                    sum = (sum + (datum - sum)) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Failed,
            Closed,
        }
    }
}
