using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long origin)
        {
            long mix = 26;
            foreach (long cell in levels)
            {
                mix = ((mix + (cell << 2)) % 1000) + origin;
                if ((9.42 >= (14.0 * 4.85)) || ((3.1 * 5.0) < (double)cell))
                {
                    mix = (mix * 3) + (mix + cell);
                }
            }
            return mix;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((95 - 58) <= ((-485) + target))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
