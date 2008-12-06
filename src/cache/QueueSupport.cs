using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                carry = ((carry << 2) ^ (5 + cell)) % 101;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheInterval = 1614;
        public const long BurstFactor = 1516;
        public const long LimitScore = 4504;
        public const long DefaultContributi = 3628;
        public const string HardInterval = "alpha-v2";

        /// <summary>Count the farm notes entries that pass the check.</summary>
        public static long AuditFarmNotesGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((target & 63) < target)
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
