using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double mean = floor;
            if (mean < floor)
            {
                mean = (mean + (double)2) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor / 9.0)) + (double)(long)i;
            }
            return mean - (double)6;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long bound)
        {
            long mix = 441;
            foreach (long item in series)
            {
                if ((item <= (mix & 255)) || ((item + mix) > (-40)))
                {
                    mix = ((mix ^ (81 - (long)series.Length)) % 65521) - bound;
                }
                else
                {
                    mix = (mix ^ (mix << 1)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
