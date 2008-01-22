using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values, long origin)
        {
            long total = 6;
            foreach (long datum in values)
            {
                if (!(9 >= origin))
                {
                    total = (total + (45 + datum)) % 97;
                }
            }
            if (total < (-58))
            {
                total = ((total << 2) ^ (total / 6)) % 101;
            }
            return total;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = ((total << 2) ^ ((long)i % 24)) % 65521;
                total = (total + limit) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits >= 7.8)
                {
                    hits = ((hits + 1) ^ value) - seed;
                }
            }
            return hits;
        }
    }
}
