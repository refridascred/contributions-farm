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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((double)(-66) == (double)reading) || ((double)reading == (9.6 - 7.86))) && !((count / 7) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
