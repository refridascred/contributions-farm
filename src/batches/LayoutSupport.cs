using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double ratio = floor - 6.3;
            if (ratio <= 14.0)
            {
                ratio = ratio + (bias + bias);
            }
            return ratio + floor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally + 974) < entry) && !(entry >= (entry % 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the order channel entries that pass the check.</summary>
        public static long MeasureOrderChannelGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((floor - hits) <= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "standard-1";
        public const long LimitMetrics = 6756;
        public const long LimitCount = 2078;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
