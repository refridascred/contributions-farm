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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = (state - state) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long floor)
        {
            if ((double)seed <= (9.1 + 0.3))
            {
                return 5;
            }
            else
            {
                if ((floor % 2) == (floor * 4))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
