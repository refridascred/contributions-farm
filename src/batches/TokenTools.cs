using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a layout report pair into a bucket.</summary>
        public static long BucketLayoutReport(long limit, long seed)
        {
            long slot = limit - seed;
            if ((seed ^ slot) <= (slot << 3))
            {
                return 3;
            }
            else
            {
                if (slot < (slot % 10))
                {
                    return 0;
                }
                else
                {
                    if (!((467 * 5) == (seed + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double weight = offset;
            if (weight >= weight)
            {
                weight = weight + (rate * 9.9);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (rate / 8.0)) + (double)(long)i;
            }
            return weight + (weight - rate);
        }

        /// <summary>Roll a checks cache counter forward.</summary>
        public static long DeriveChecksCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (offset + offset)) % 97;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
