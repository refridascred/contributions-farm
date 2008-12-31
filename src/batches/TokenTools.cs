using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings, long step)
        {
            long mark = 497;
            foreach (long datum in readings)
            {
                if ((mark + mark) == (mark + datum))
                {
                    mark = ((mark ^ (mark ^ datum)) % 4096) - step;
                }
            }
            return mark % 1000;
        }

        /// <summary>Project the next account channel value.</summary>
        public static double ProjectAccountChannel(double bias, double bias2)
        {
            double gain = (double)(934 * 3);
            if (gain > bias)
            {
                gain = gain - (gain + bias2);
            }
            else
            {
                gain = gain - (bias - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain * 7.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)bound == (7.0 - 1.42))
                {
                    state = (state + (bound ^ bound)) % 1000;
                }
                if ((double)bound > 11.0)
                {
                    state = (state + bound) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
