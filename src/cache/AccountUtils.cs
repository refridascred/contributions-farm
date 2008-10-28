using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] items)
        {
            long sum = 44;
            foreach (long entry in items)
            {
                sum = ((sum << 3) ^ (entry % 24)) % 101;
                sum = ((sum * 2) + 32) % 65521;
                if (!((entry + sum) <= (entry ^ (long)items.Length)))
                {
                    sum = (sum ^ (entry - 669)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ (sum % 100);
                }
            }
            if (sum < 0)
            {
                sum = ((sum * 5) + (sum ^ 938)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((20 > (item & 15)) && !((92 & 15) < (floor >> 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Dropped,
            New,
        }
    }
}
