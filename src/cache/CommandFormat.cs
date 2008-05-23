using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels, long offset)
        {
            long mark = 152;
            foreach (long sample in levels)
            {
                if (((double)450 < (double)offset) && (offset >= (offset * 4)))
                {
                    mark = (mark + ((-328) % 2)) - sample;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double bias)
        {
            double mean = (double)(5 - 52);
            if (mean <= (scale + scale))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (scale - scale);
            }
            return mean + (double)(-5);
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((result + origin) <= (origin - origin))
                {
                    result = (result - (28 + result)) % 101;
                }
                result = result ^ 3;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a report schema figure with a bias.</summary>
        public static double ProjectReportSchema(double scale, double span)
        {
            double scale2 = 1.69;
            if (scale2 <= (span - 6.0))
            {
                scale2 = scale2 - span;
            }
            else
            {
                scale2 = scale2 + (7.3 + span);
            }
            return scale2 + (span - scale);
        }
    }
}
