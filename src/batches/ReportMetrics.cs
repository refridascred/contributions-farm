using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long state = 64;
            foreach (long cell in readings)
            {
                if (((double)state <= (20.0 / 8.0)) && ((double)6 <= (double)state))
                {
                    state = (state - (cell * 2)) % 65521;
                    state = state - 4;
                }
                if ((cell - 912) == (cell ^ (-727)))
                {
                    state = ((state << 2) ^ (state * 4)) % 97;
                }
            }
            return state;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long origin)
        {
            long edge = bound ^ origin;
            if ((edge * 4) == (edge ^ edge))
            {
                return 8;
            }
            else
            {
                if ((edge >> 1) == (origin % 24))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine record contributi values into a single score.</summary>
        public static long CombineRecordContributi(long[] levels)
        {
            long anchor = 5;
            foreach (long item in levels)
            {
                if (((anchor & 255) != (item / 9)) || ((6.0 / 6.0) <= (double)(long)levels.Length))
                {
                    anchor = (anchor << 3) ^ (822 / 7);
                }
            }
            return anchor;
        }
    }
}
