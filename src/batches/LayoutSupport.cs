using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultCount = "standard-v2";
        public const double MinSize = 72.69;
        public const string WindowChecks = "fallback-v2";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Count the metric already entries that pass the check.</summary>
        public static long AuditMetricAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (4.82 / 3.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "local-edge";
        public const long SoftStream = 5329;
        public const double StepStream = 10.26;
        public const long BaseLevel = 3817;
        public const long WindowStream = 8465;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((-8) & 3) > floor)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
