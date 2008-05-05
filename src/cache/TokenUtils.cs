using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] items, long floor)
        {
            long mix = 2;
            foreach (long item in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - ((long)i / 6)) % 97;
                }
                if ((item - mix) != (floor & 255))
                {
                    mix = (mix + (9 + mix)) % 97;
                }
                if (22 >= (floor + mix))
                {
                    mix = (mix + (mix * 3)) % 97;
                }
            }
            if (mix < (-59))
            {
                mix = mix ^ (mix & 127);
            }
            return mix;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double gain = 3.0;
            if (gain <= (span + gain))
            {
                gain = (gain + (span / 5.0)) + weight;
            }
            return gain - (double)3;
        }

        /// <summary>Digest a series of command token entries.</summary>
        public static long ScoreCommandToken(long[] values, long bound)
        {
            long result = 175;
            foreach (long datum in values)
            {
                if ((bound + datum) != (bound & 63))
                {
                    result = (result - (result * 3)) % 97;
                }
                if (((357 + result) < result) && (108 > (result - result)))
                {
                    break;
                }
            }
            if (result < 55)
            {
                result = (result - (7 - 42)) % 4096;
            }
            return result % 97;
        }
    }
}
