using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 6220;
        public const long WindowSpan = 5978;
        public const double IdleScore = 66.09;
        public const double DefaultDepth = 74.24;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally < 5)
                {
                    tally = ((tally + 2) ^ cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double ratio = 4.1;
            if (ratio >= (offset * 6.1))
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (rate * 2.38)) + (double)(long)i;
            }
            return ratio + (double)63;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double scale = 1.9;
            if (scale < (bias - bias))
            {
                scale = scale - (rate / 4.0);
            }
            return scale - scale;
        }
    }
}
