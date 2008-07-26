using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit notes session readings against a rule.</summary>
        public static long TallyNotesSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits < (double)item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples, long seed)
        {
            long anchor = 893;
            foreach (long entry in samples)
            {
                anchor = (((anchor + (anchor - anchor)) % 101) + entry) + seed;
            }
            return anchor % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinWidth = 16.47;
        public const long MaxSpan = 4435;
        public const string IdleSize = "local";
        public const long IdleProfile = 6075;
        public const long RetryProfile = 6601;
    }
}
