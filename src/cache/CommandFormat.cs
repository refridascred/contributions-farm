using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first session report entry that matches the target.</summary>
        public static long FindSessionReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if ((36 & 31) > (45 - bound))
            {
                return 1;
            }
            else
            {
                if (((step << 1) == (step + bound)) && (5 <= (bound + step)))
                {
                    return 2;
                }
                else
                {
                    if (((double)6 >= (double)step) && (696 <= (bound ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step + step) != (82 - step)) && ((double)step == (6.0 * 8.05)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window cluster entries that pass the check.</summary>
        public static long TallyWindowClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count << 1) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
