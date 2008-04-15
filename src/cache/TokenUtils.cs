using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a record tools reading by value.</summary>
        public static long FindRecordToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((85 / 7) <= (matches + 7)) || ((4.0 + 7.19) == (double)matches)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double mean = weight;
            if (mean > (bias + weight))
            {
                mean = mean + 7.0;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (bias / 6.0);
        }
    }
}
