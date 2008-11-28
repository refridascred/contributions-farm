using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count == (8.3 * 2.7))
                {
                    count = ((count + 1) ^ datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 151;
        public const long SoftFactor = 6945;
        public const double SoftScore = 97.52;
        public const long MaxScore = 705;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
