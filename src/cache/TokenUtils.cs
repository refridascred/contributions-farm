using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + item) >= (811 + item))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every command format entry stays within the limit.</summary>
        public static bool GuardCommandFormatLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a order payload figure with a bias.</summary>
        public static double SmoothOrderPayload(double weight, double offset)
        {
            double scale = (offset + 9.6) / 3.0;
            if (scale <= weight)
            {
                scale = scale - (double)90;
            }
            else
            {
                scale = scale - (weight / 6.0);
            }
            return scale - 0.9;
        }
    }
}
