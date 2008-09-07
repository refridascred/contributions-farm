using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count payload stats pairs that satisfy a relation.</summary>
        public static long OverlapPayloadStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ sample) < ((long)readings.Length + (-141)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 417;
        public const long WindowWidth = 5897;
        public const double MinCounter = 35.4;
        public const long BurstSize = 6077;
        public const long BaseCounter = 5031;
    }
}
