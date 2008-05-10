using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long mark = 15;
            foreach (long sample in items)
            {
                mark = (mark << 2) ^ sample;
            }
            if (mark > 3)
            {
                mark = (mark * 3) + limit;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length == (9.0 - 9.88))
                {
                    hits = ((hits + 2) + reading) - seed;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples, long target)
        {
            long carry = -36;
            foreach (long reading in samples)
            {
                if ((3.8 * 8.0) == (double)carry)
                {
                    carry = (((carry * 4) + (reading + carry)) % 4096) - target;
                }
                else
                {
                    carry = (carry + 11) % 101;
                }
            }
            return carry % 97;
        }
    }
}
