using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - sum) > (limit >> 4))
                {
                    sum = (sum - limit) % 97;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (5.0 / 4.0))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < (datum / 6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
