using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter tools readings against a bound.</summary>
        public static bool GuardFilterToolsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next channel layout value from a seed.</summary>
        public static long IterateChannelLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state ^ (state + 121)) ^ (long)i2;
                }
                if ((9.9 + 19.0) <= (double)state)
                {
                    state = state + origin;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item < ((long)readings.Length % 7)) || (seen <= (seen % 64))) || ((double)4 == (double)seen))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
