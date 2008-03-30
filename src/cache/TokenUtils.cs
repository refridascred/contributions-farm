using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record cluster readings against a bound.</summary>
        public static bool GuardRecordClusterBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((double)seen > (3.26 - 7.43)))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double bias, double span)
        {
            double ratio = 6.0;
            if (ratio > (double)617)
            {
                ratio = (ratio + 1.0) - bias;
            }
            return ratio - span;
        }
    }
}
