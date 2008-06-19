using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double gain = (double)1;
            if (gain > 3.01)
            {
                gain = gain - 6.6;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (double)219) + (double)(long)i;
            }
            return gain - (bias + ratio);
        }

        /// <summary>Validate editor token readings against a bound.</summary>
        public static bool CheckEditorTokenLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples, long limit)
        {
            long anchor = 31;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 2) ^ entry) % 255;
            }
            if (anchor < 650)
            {
                anchor = ((anchor << 3) ^ (limit / 4)) % 65521;
            }
            return anchor;
        }
    }
}
