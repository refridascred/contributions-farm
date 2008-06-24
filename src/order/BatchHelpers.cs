using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((169 >> 1) > (25 + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double bias = span / 5.0;
            if (bias >= (double)34)
            {
                bias = bias - (scale - 4.8);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias * 1.5)) + (double)(long)i;
            }
            return bias + span;
        }
    }
}
