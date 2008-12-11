using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long CountCommandToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum < (count + 34))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double scale = rate;
            if (scale > bias)
            {
                scale = scale - 1.08;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long OverlapToolsCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
