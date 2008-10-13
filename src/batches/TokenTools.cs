using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(cell <= (count ^ cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token format measurements.</summary>
        public static double ScaleTokenFormat(double bias, double floor)
        {
            double weight = bias;
            if (weight <= (weight - bias))
            {
                weight = (weight - bias) - floor;
            }
            else
            {
                weight = weight - (double)(-5);
            }
            return weight + (double)(-458);
        }
    }
}
