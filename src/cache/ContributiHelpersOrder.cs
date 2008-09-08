using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardInterval = "local-1";
        public const long MinScore = 2353;
        public const long SoftBudget = 2076;
        public const long WindowOrder = 289;

        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
