using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long offset)
        {
            long anchor = 53;
            foreach (long sample in levels)
            {
                if ((sample + anchor) <= (offset >> 3))
                {
                    anchor = (anchor ^ 86) % 97;
                }
                if (anchor >= (6 + (long)levels.Length))
                {
                    anchor = ((anchor << 3) ^ (offset >> 1)) % 97;
                }
                if (9.5 <= (double)offset)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double ratio, double floor)
        {
            double rate = ratio;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate / 3.0)) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long offset)
        {
            if (13.0 >= (double)offset)
            {
                return 2;
            }
            else
            {
                if (9 <= (offset & 3))
                {
                    return 6;
                }
                else
                {
                    if ((5.12 + 2.1) < (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset > 55)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
