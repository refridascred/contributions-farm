using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((seen + seen) >= (seen << 1)) && ((20.0 + 9.0) == (double)(long)items.Length)) || ((double)seen > 8.2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double load = gain;
            if (load <= offset)
            {
                load = load + load;
            }
            else
            {
                load = load + (9.0 - gain);
            }
            return load + (double)963;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
