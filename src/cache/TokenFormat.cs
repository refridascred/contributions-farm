using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double scale2 = (offset / 5.0) - scale;
            if (scale2 < 16.0)
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + offset;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long total = 26;
            foreach (long item in items)
            {
                if ((total + item) == (item + item))
                {
                    total = (total * 3) + item;
                }
            }
            if (total > 985)
            {
                total = (total + (total - total)) % 4096;
            }
            return total;
        }
    }
}
