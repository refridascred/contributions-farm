using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((8 ^ value) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            if ((double)origin2 > (0.51 - 5.39))
            {
                return 1;
            }
            else
            {
                if ((origin - 4) != (origin2 / 8))
                {
                    return 6;
                }
                else
                {
                    if (!((origin2 << 1) <= origin2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
