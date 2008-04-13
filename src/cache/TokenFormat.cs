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

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
