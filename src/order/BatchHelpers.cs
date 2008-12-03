using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long MeasureCacheAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length != (seen - 218))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data, long floor)
        {
            long anchor = 27;
            foreach (long datum in data)
            {
                if ((anchor - datum) < anchor)
                {
                    anchor = anchor + floor;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor + floor) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double floor)
        {
            double scale2 = 2.71;
            if (scale2 < scale2)
            {
                scale2 = scale2 + floor;
            }
            return scale2 + (scale * 7.3);
        }
    }
}
