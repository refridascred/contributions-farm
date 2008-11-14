using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 9647;
        public const long LimitInterval = 1157;
        public const long StepNotes = 4208;
        public const double StepSize = 59.98;
        public const long IdleNotes = 9504;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
