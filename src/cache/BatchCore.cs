using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((15.0 * 8.0) < (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream report value.</summary>
        public static double BlendStreamReport(double ratio, double floor)
        {
            double bias = floor;
            if (bias < 19.0)
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)0) - (double)(long)i;
            }
            return bias - ratio;
        }
    }
}
