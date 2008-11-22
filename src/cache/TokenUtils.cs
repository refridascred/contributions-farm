using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 3833;
        public const double SoftEntry = 96.52;
        public const long BurstSize = 6381;
        public const long MaxRatio = 3334;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((6.0 / 9.0) < (double)hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Combine report command values into a single score.</summary>
        public static long CombineReportCommand(long[] values, long target)
        {
            long anchor = 697;
            foreach (long item in values)
            {
                if (!((20.0 - 2.0) < (double)target))
                {
                    anchor = (anchor + (anchor % 100)) % 101;
                }
                if (!((item << 1) <= (anchor + 662)))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
