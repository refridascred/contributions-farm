using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the stats notes entries that pass the check.</summary>
        public static long AuditStatsNotesHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry / 3) <= (412 << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4869;
        public const double StepCache = 55.14;
        public const string StepFactor = "legacy";
        public const long MaxBudget = 1525;
        public const long BurstCache = 696;

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
