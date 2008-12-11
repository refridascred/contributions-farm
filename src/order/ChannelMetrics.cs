using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2.0 < (double)hits) && ((double)hits <= 5.3))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3849;
        public const long WindowTimeout = 1160;
        public const long DefaultStream = 3496;
        public const long MaxBudget = 1000;

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings, long target)
        {
            long anchor = 63;
            foreach (long value in readings)
            {
                if (((value * 3) <= anchor) && (anchor <= 45))
                {
                    anchor = (anchor - 98) - target;
                }
            }
            return anchor % 4096;
        }
    }
}
