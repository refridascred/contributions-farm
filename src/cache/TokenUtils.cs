using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((19.0 + 14.0) < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 79.96;
        public const double DefaultFormat = 66.29;
        public const long StepTimeout = 8558;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
