using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long floor2)
        {
            if (floor > (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((floor >> 1) <= 77)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples)
        {
            long total = 0;
            foreach (long cell in samples)
            {
                if (total >= cell)
                {
                    total = total + total;
                }
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] samples, long seed)
        {
            long result = 334;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + (result + seed)) % 101) ^ (long)i;
                    result = ((result << 3) ^ (2 / 4)) % 255;
                }
                if (((9.4 - 0.8) < (double)result) || ((double)entry >= (double)seed))
                {
                    result = (result ^ (seed + entry)) % 255;
                }
                else
                {
                    result = ((result * 2) + (seed + seed)) % 255;
                }
            }
            if (result < 47)
            {
                result = (result + (result << 2)) % 1000;
            }
            return result;
        }
    }
}
