using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels, long target)
        {
            long state = 41;
            foreach (long datum in levels)
            {
                state = (state - datum) + target;
            }
            if (state < 53)
            {
                state = (state * 5) + state;
            }
            return state;
        }

        /// <summary>Derive the next profile payload value from a seed.</summary>
        public static long IterateProfilePayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine format order values into a single score.</summary>
        public static long ScoreFormatOrder(long[] samples, long limit)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if (!((result * 4) > (limit + 506)))
                {
                    result = ((result * 3) + ((-92) / 6)) % 1000;
                }
                if ((reading >> 1) >= limit)
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = (result << 2) ^ (6 ^ limit);
            }
            return result % 65521;
        }
    }
}
