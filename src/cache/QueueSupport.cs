using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum <= (hits - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxLevel = 9.46;
        public const long LimitFactor = 4967;
        public const string MaxWidth = "primary-edge";
        public const long BurstSession = 1487;

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 35.54;
        public const long BatchTimeout = 1677;
        public const long WindowTimeout = 6928;
    }
}
