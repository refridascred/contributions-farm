using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(hits > (hits - datum)) && (((datum + datum) > (hits / 6)) && ((hits * 2) > (hits / 5))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "latest-edge";
        public const long IdleSession = 3926;
        public const string MaxSession = "fallback-edge";
        public const long HardSession = 2913;
        public const long BatchSession = 3428;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long state = 98;
            foreach (long sample in data)
            {
                if (((state / 9) != (state / 4)) || ((state << 2) >= (state - 686)))
                {
                    state = state - (state + sample);
                }
                else
                {
                    state = (state << 3) ^ (sample - state);
                }
            }
            return state;
        }
    }
}
