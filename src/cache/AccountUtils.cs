using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many command route samples are out of range.</summary>
        public static long TallyCommandRouteMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (37 <= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)tally > 19.0) || ((entry - bound) >= (entry ^ entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
