using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double drift = ratio;
            if (drift < (double)4)
            {
                drift = drift - (span / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + 7.1) + (double)(long)i;
            }
            return drift + (3.0 + 13.0);
        }

        /// <summary>Measure how many window tools samples are out of range.</summary>
        public static long CountWindowToolsGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((3.4 + 7.2) == (double)hits)
                {
                    hits = ((hits + 1) - item) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes command samples are out of range.</summary>
        public static long TallyNotesCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen % 5) >= (datum & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
