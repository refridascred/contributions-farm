using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((4.95 - 8.7) < (double)value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long floor2)
        {
            if (floor2 <= (floor2 + floor2))
            {
                return 7;
            }
            else
            {
                if ((8.3 * 9.0) != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor2 % 100) < (floor >> 1))
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

        /// <summary>Project the next checks format value.</summary>
        public static double BlendChecksFormat(double rate, double floor)
        {
            double bias = rate;
            return (bias - 20.0) + floor;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Synced,
            Active,
        }
    }
}
