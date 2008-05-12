using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((double)hits < (8.2 * 6.1)) && ((value / 6) > value)) && ((162 + value) < (value + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((486 - cell) > (floor & 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardBudget = "open-1";
        public const long MaxRatio = 688;
        public const long BurstWindow = 8577;
        public const string HardSpan = "latest";

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftInterval = 2130;
        public const string HardFactor = "primary-v2";
        public const long MinQueue = 1016;
    }
}
