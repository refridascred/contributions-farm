using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((-240) & 1) >= (seen & 1)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheScore = 6255;
        public const long CacheCommand = 1403;
        public const string IdleCommand = "stable-v2";
        public const long WindowLevel = 3119;
        public const long BaseFactor = 893;
    }
}
