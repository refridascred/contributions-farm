using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
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
