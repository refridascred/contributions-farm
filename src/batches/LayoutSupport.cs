using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 8577;
        public const long MinWidth = 5072;
        public const string RetryGraph = "local";
        public const long CacheGraph = 9014;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Closed,
            New,
        }

        /// <summary>Measure how many layout batches samples are out of range.</summary>
        public static long MeasureLayoutBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)item < (6.7 * 17.0)) && ((7.0 + 2.4) <= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double gain = 17.0;
            if (gain <= (double)76)
            {
                gain = (gain + span) - scale;
            }
            else
            {
                gain = gain + span;
            }
            return gain - (gain + gain);
        }
    }
}
