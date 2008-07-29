using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 6730;
        public const long DefaultRecord = 1568;
        public const long HardDepth = 3970;
        public const long LimitRecord = 6119;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((-36) - matches) >= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - 2) <= 68) && (item < (3 * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
