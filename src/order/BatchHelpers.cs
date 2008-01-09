using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double floor)
        {
            double scale2 = (8.0 * 19.0) / 8.0;
            if (scale2 >= floor)
            {
                scale2 = scale2 + scale;
            }
            return scale2 - floor;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
