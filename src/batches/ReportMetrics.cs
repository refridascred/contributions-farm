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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)step < (8.64 + 5.9))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
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
