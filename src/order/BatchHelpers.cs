using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double span)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (8.9 / 9.0)) + (double)(long)i;
            }
            return ratio + (span + ratio);
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
