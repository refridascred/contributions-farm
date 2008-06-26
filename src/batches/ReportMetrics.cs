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

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 2315;
        public const long BaseChecks = 9491;
        public const double HardSize = 32.66;
        public const string DefaultTimeout = "primary";
        public const string BatchFactor = "alpha";

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
