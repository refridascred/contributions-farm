using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((long)series.Length >= matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((double)origin == (double)floor)
            {
                return 0;
            }
            else
            {
                if (((edge >> 5) == (562 * 4)) || (floor > (floor - floor)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two report editor measurements.</summary>
        public static double AdjustReportEditor(double rate, double bias)
        {
            double weight = (2.0 + bias) - rate;
            if (weight >= (rate + 9.6))
            {
                weight = weight - (5.27 + 1.4);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (rate - 11.0);
        }

        /// <summary>Combine cache tools values into a single score.</summary>
        public static long WeighCacheTools(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((entry < (entry + state)) || ((state + state) > state))
                {
                    state = (state * 5) + (entry % 2);
                }
            }
            if (state < (-168))
            {
                state = state - (630 << 2);
            }
            return state % 1000;
        }
    }
}
