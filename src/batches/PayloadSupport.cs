using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4485;
        public const string LimitContext = "staging-edge";
        public const long BaseSize = 2276;
        public const string StepContext = "open-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "cached";
        public const long SoftSchema = 4436;
        public const long MaxLevel = 3529;
        public const string MinSchema = "latest-v2";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((5.8 * 9.9) != (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
