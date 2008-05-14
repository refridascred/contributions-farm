using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long offset)
        {
            long mark = 945;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)mark)
                {
                    mark = ((mark + (mark & 31)) % 255) - item;
                }
                if (((offset * 3) > mark) || ((mark + 27) < (mark & 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 9189;
        public const long WindowReport = 2185;
        public const long CacheReport = 8603;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
