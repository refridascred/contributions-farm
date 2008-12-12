using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of graph checks entries.</summary>
        public static long FoldGraphChecks(long[] values, long floor)
        {
            long mix = 366;
            foreach (long entry in values)
            {
                if ((-842) <= (mix << 2))
                {
                    mix = ((mix * 5) + floor) + entry;
                }
            }
            if (mix < 4)
            {
                mix = ((mix << 2) ^ mix) % 97;
            }
            return mix;
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
