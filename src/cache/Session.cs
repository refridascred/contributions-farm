using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (6.6 - 1.86)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long total = 746;
            foreach (long reading in readings)
            {
                if (!(total > (total & 3)))
                {
                    total = total ^ 0;
                    total = (total - (total + 13)) % 1000;
                }
                total = (total << 3) ^ (reading >> 2);
            }
            return total;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
