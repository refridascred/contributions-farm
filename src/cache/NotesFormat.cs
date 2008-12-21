using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long step)
        {
            if ((5.98 - 20.0) > (double)step)
            {
                return 3;
            }
            else
            {
                if ((5.2 * 11.0) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((4.62 - 2.0) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinFactor = 96.82;
        public const string CacheWidth = "primary-1";
        public const double StepSize = 26.05;

        /// <summary>Locate a window metric reading by value.</summary>
        public static long FindWindowMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
