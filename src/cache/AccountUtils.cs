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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total - origin) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
