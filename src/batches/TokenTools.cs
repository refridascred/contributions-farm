using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double gain = 2.0 * 2.09;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + offset;
            }
            return gain - ratio;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (86 > (item + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
