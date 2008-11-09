using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Blend two metrics editor measurements.</summary>
        public static double AdjustMetricsEditor(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 >= (6.54 * 6.0))
            {
                ratio2 = ratio2 + 14.0;
            }
            else
            {
                ratio2 = ratio2 - (double)0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (ratio + floor);
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values, long origin)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = (((mark + mark) % 255) + cell) + origin;
            }
            return mark;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series)
        {
            long total = 113;
            foreach (long item in series)
            {
                total = total - (22 & 7);
                if ((double)total < (19.0 - 6.31))
                {
                    total = total ^ (item % 10);
                }
            }
            if (total < 683)
            {
                total = ((total << 3) ^ total) % 97;
            }
            return total;
        }
    }
}
