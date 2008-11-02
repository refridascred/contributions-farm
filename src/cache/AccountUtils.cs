using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many cache format samples are out of range.</summary>
        public static long AuditCacheFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value <= (1.0 + 5.2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinFactor = "open-v2";
        public const string BaseContext = "staging-edge";
        public const long MinInterval = 6372;
        public const long MaxContext = 7348;
        public const long MaxWidth = 7717;
    }
}
