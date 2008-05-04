using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items, long seed)
        {
            long acc = 23;
            foreach (long reading in items)
            {
                acc = (((acc - acc) % 97) ^ reading) - seed;
                acc = (acc ^ 1) % 1000;
            }
            if (acc < 4)
            {
                acc = acc ^ acc;
            }
            return acc % 65521;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double load = gain - 8.16;
            if (load > (offset - offset))
            {
                load = load - load;
            }
            return load + load;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double scale = (3.0 / 9.0) * 20.0;
            if (scale <= (double)4)
            {
                scale = (scale - (double)2) - bias2;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + scale;
        }
    }
}
