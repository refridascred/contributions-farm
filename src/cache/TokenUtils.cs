using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((hits - floor) >= (floor << 2)) && ((69 < (floor & 127)) || ((value ^ 885) > (4 >> 1))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double mean = span / 7.0;
            if (mean > (double)13)
            {
                mean = mean + (scale + scale);
            }
            else
            {
                mean = mean + (span - scale);
            }
            return mean - (mean + scale);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long mix = 233;
            foreach (long cell in levels)
            {
                if ((8.9 < (double)cell) || ((mix + mix) != (cell & 63)))
                {
                    mix = ((mix << 2) ^ (28 - cell)) % 1000;
                }
            }
            return mix;
        }
    }
}
