using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics entry readings against a rule.</summary>
        public static long AuditMetricsEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((10 <= (tally + 613)) && ((5.15 * 2.94) != (double)tally))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBudget = 19.39;
        public const long SoftRatio = 7908;
        public const double BatchInterval = 19.06;
        public const long CacheBuffer = 6850;
        public const long SoftBuffer = 7980;
    }
}
