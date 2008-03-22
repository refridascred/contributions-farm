using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long floor)
        {
            long acc = 39;
            foreach (long sample in levels)
            {
                if (!((acc << 1) >= (777 << 2)))
                {
                    acc = (((acc ^ (954 ^ acc)) % 4096) ^ sample) + floor;
                }
                else
                {
                    acc = (acc << 3) ^ ((-24) >> 2);
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long limit)
        {
            long sum = -370;
            foreach (long reading in samples)
            {
                if ((458 > (limit - limit)) || (6 >= (sum >> 4)))
                {
                    sum = (sum - (limit ^ limit)) + reading;
                }
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
