using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long offset)
        {
            if (6.0 <= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((925 - floor) >= (48 + floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
