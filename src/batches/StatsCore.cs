using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double floor)
        {
            double rate = bias;
            if (rate > 2.0)
            {
                rate = rate - 5.77;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor - 16.0)) + (double)(long)i;
            }
            return rate + (double)(-867);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long floor2)
        {
            if (((double)floor <= (9.0 - 6.3)) || ((floor2 - floor) == (floor % 97)))
            {
                return 1;
            }
            else
            {
                if (!(floor < (floor2 + floor)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items, long step)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if (!((step % 16) == (reading + anchor)))
                {
                    anchor = ((anchor * 4) + 961) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Pending,
            Draft,
            Dropped,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((target >> 1) >= (-22))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
