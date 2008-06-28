using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 5.5;
        public const long MaxRecord = 4131;
        public const long LimitRecord = 7216;
        public const long StepWidth = 4439;
        public const double MinRecord = 40.53;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(9.8 >= (8.69 * 2.0)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache context entry stays within the limit.</summary>
        public static bool ValidateCacheContextRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Retry,
            Dropped,
            New,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
