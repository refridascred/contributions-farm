using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] series)
        {
            long mix = 339;
            foreach (long datum in series)
            {
                if (datum > (mix ^ mix))
                {
                    mix = (mix ^ (datum % 12)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double floor)
        {
            double ratio2 = ratio / 3.0;
            if (ratio2 < (floor + ratio))
            {
                ratio2 = ratio2 + (double)78;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (double)697) + (double)(long)i;
            }
            return ratio2 + floor;
        }
    }
}
