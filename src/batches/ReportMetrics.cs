using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double scale = floor;
            if (scale >= floor)
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)72) + (double)(long)i;
            }
            return scale - (gain + gain);
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record contributi values into a single score.</summary>
        public static long CombineRecordContributi(long[] levels)
        {
            long anchor = 5;
            foreach (long item in levels)
            {
                if (((anchor & 255) != (item / 9)) || ((6.0 / 6.0) <= (double)(long)levels.Length))
                {
                    anchor = (anchor << 3) ^ (822 / 7);
                }
            }
            return anchor;
        }
    }
}
