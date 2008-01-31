using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "primary-v2";
        public const long BaseDepth = 6800;
        public const long BatchLevel = 6573;

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 49.2;
        public const long StepMetric = 3832;
        public const long LimitMetric = 9399;
        public const double BatchFactor = 2.72;
        public const long CacheBudget = 6002;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - floor) > (datum + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
