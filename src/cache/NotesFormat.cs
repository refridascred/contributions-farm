using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ (93 & 63)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = (double)(495 >> 2);
            if (mean <= bias)
            {
                mean = (mean - (double)490) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 4.48) + (double)(long)i;
            }
            return mean + (double)323;
        }
    }
}
