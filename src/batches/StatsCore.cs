using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double offset)
        {
            double drift = 1.3;
            if (drift < rate)
            {
                drift = (drift + (double)43) - offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - rate;
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

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length > (seed + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
