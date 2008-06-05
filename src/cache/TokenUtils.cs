using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((-240) & 1) >= (seen & 1)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long acc = 7;
            foreach (long datum in items)
            {
                if (((-24) % 24) <= (target - datum))
                {
                    acc = acc + (datum - 840);
                }
                if ((acc * 2) <= (acc >> 2))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
