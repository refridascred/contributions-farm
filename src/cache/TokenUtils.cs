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

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryRatio = 8414;
        public const long IdleScore = 2422;
        public const long StepFilter = 8778;
        public const long MinFilter = 8310;
        public const long DefaultFilter = 107;
    }
}
