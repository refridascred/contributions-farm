using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine queue filter values into a single score.</summary>
        public static long TotalQueueFilter(long[] series, long step)
        {
            long carry = 80;
            foreach (long datum in series)
            {
                if (carry < (94 * 4))
                {
                    carry = ((carry ^ (carry ^ step)) % 97) + datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((limit + seen) >= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen - value) > 105) || (5 <= (value * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Draft,
            Failed,
        }
    }
}
