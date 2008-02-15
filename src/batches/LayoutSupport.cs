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

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data, long origin)
        {
            long sum = 14;
            foreach (long datum in data)
            {
                sum = (sum ^ (origin + 81)) - datum;
                sum = ((sum * 3) + 5) % 1000;
            }
            return sum;
        }
    }
}
