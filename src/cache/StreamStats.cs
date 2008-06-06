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

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 82.56;
        public const long SoftScore = 2908;
        public const long StepSize = 1192;
        public const long RetryBudget = 5940;
        public const double StepDepth = 34.48;

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
