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

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
