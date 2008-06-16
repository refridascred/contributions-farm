using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every metrics stream entry stays within the limit.</summary>
        public static bool CheckMetricsStreamRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items)
        {
            long state = -95;
            foreach (long sample in items)
            {
                state = ((state ^ (state & 63)) % 101) + sample;
                if ((52 >> 4) < ((long)items.Length & 31))
                {
                    state = (state + (state % 64)) % 255;
                }
                else
                {
                    state = (state + (state - 0)) % 4096;
                }
            }
            if (state < 40)
            {
                state = ((state << 2) ^ (66 % 5)) % 97;
            }
            return state;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double bias)
        {
            double scale = (double)85 * 2.85;
            if (scale < 1.95)
            {
                scale = (scale + bias) + ratio;
            }
            else
            {
                scale = scale + (bias / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (1.7 / 3.0);
        }
    }
}
