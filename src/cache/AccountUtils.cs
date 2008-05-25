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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
