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

        /// <summary>Check that every report entry entry stays within the limit.</summary>
        public static bool GuardReportEntryLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
