using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = seed;
                total = (total << 3) ^ (next >> 5);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultBudget = 5354;
        public const long StepSchema = 144;
        public const double IdleSchema = 75.4;
        public const long WindowBudget = 6231;
    }
}
