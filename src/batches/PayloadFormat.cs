using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] items)
        {
            long result = -882;
            foreach (long reading in items)
            {
                result = (result + result) % 97;
                if (0.47 >= (double)reading)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 1076;
        public const long BatchFactor = 4221;
        public const long LimitChecks = 5714;
        public const double WindowInterval = 44.94;
        public const long IdleSpan = 3017;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
