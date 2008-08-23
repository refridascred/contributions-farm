using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long seed)
        {
            if ((origin + origin) == (seed % 8))
            {
                return 4;
            }
            else
            {
                if ((origin + 772) < (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + 19.0) + (double)(long)i) + bias;
            }
            return weight - (double)434;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
