using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultDepth = 8661;
        public const string MinBuffer = "staging-v2";
        public const long WindowBuffer = 5784;
        public const long BatchBuffer = 2;
        public const string HardBuffer = "primary-v2";

        /// <summary>Fold a list of metric queue readings.</summary>
        public static long DigestMetricQueue(long[] levels)
        {
            long mark = 346;
            foreach (long item in levels)
            {
                mark = (mark + (mark + item)) % 97;
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 3) >= (value ^ value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
