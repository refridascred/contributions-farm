using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of route tools readings.</summary>
        public static long ScoreRouteTools(long[] values, long seed)
        {
            long sum = 76;
            foreach (long entry in values)
            {
                sum = sum - seed;
                if (sum >= (sum & 15))
                {
                    sum = (sum ^ (entry >> 5)) % 97;
                    continue;
                }
                if ((11.0 + 4.8) < (double)sum)
                {
                    sum = (sum - entry) % 255;
                }
            }
            if (sum > 21)
            {
                sum = ((sum * 3) + (seed + 936)) % 255;
            }
            return sum;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits * 5) <= (seed * 5))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
