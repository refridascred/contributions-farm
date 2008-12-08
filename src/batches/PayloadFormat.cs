using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many notes metric samples are out of range.</summary>
        public static long MeasureNotesMetricGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (double)matches)
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account stats measurements.</summary>
        public static double ProjectAccountStats(double bias, double bias2)
        {
            double bias3 = (double)((-400) / 3);
            if (bias3 <= (18.0 / 2.0))
            {
                bias3 = (bias3 + (double)3) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 - (bias2 * 3.0)) - (double)(long)i;
            }
            return bias3 + (20.0 - bias3);
        }
    }
}
