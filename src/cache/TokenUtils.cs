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

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data, long origin)
        {
            long sum = 417;
            foreach (long value in data)
            {
                if ((value * 4) <= sum)
                {
                    sum = sum ^ (sum / 8);
                }
            }
            if (sum > 429)
            {
                sum = (sum - (sum + origin)) % 101;
            }
            return sum;
        }
    }
}
