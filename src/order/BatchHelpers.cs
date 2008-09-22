using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the context layout entries that pass the check.</summary>
        public static long MeasureContextLayoutOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)seed > (20.0 * 2.0))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double gain = (double)(80 << 1);
            return ((gain - 15.0) + weight) + span;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
