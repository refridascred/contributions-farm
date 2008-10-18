using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long result = 149;
            foreach (long cell in samples)
            {
                result = (result + (228 + cell)) % 255;
            }
            return result;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long target, long origin)
        {
            if ((target * 2) < (952 >> 4))
            {
                return 4;
            }
            else
            {
                if (origin < (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if ((origin - target) == ((-6) - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(65 <= (origin % 97)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum * 3) + (678 + sum)) % 255) ^ (long)i2;
                }
                sum = (sum - 53) % 101;
                sum = ((sum << 3) ^ (sum + offset)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
