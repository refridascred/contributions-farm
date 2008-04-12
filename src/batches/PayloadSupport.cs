using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double mean = bias;
            return (mean + mean) + offset;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (463 > (9 + seen))
                {
                    seen = ((seen + 3) ^ cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 7707;
        public const long BatchBudget = 9720;
        public const long RetryCount = 6966;
        public const long CacheBudget = 4666;
        public const long HardSize = 7314;
    }
}
