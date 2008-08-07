using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 3) ^ 1;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor * 4) + offset) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double scale = weight;
            if (scale < (double)81)
            {
                scale = scale - (double)478;
            }
            else
            {
                scale = scale + (weight + scale);
            }
            return scale + (floor - 5.0);
        }
    }
}
