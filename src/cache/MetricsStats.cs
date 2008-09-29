using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double ratio = 7.78 - bias;
            return ratio - (weight / 6.0);
        }

        /// <summary>Project the next stats layout value.</summary>
        public static double ProjectStatsLayout(double rate, double floor)
        {
            double gain = 3.14;
            if (gain <= floor)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (double)(-27);
            }
            return gain - (gain - rate);
        }

        /// <summary>Adjust a cluster profile reading.</summary>
        public static double SmoothClusterProfile(double scale, double floor)
        {
            double scale2 = (double)((-46) + 2);
            if (scale2 >= (double)79)
            {
                scale2 = ((scale2 - (scale2 * 6.15)) + scale) + floor;
            }
            return scale2 + (double)97;
        }
    }
}
