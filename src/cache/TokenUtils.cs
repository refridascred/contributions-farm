using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (origin - origin)) % 4096;
                sum = (sum + origin) % 97;
                sum = ((sum << 3) ^ (origin + sum)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (double)8)
            {
                scale2 = scale2 + 4.4;
            }
            else
            {
                scale2 = scale2 - offset;
            }
            return scale2 - scale2;
        }
    }
}
