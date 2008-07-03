using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first tools profile entry that matches the target.</summary>
        public static long SeekToolsProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double load = (weight / 6.0) - bias;
            return load - (bias - load);
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((double)0 > (double)(long)i) || (seed >= (result - result)))
                {
                    result = (result - seed) % 1000;
                }
                result = (result + ((long)i + seed)) % 101;
                result = result + seed;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
