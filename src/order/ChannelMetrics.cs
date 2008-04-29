using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double mean = ratio * 7.5;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + 5.6;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long seed)
        {
            if (((27 + 6) > step) || ((double)seed <= 10.0))
            {
                return 4;
            }
            else
            {
                if ((seed / 6) <= seed)
                {
                    return 6;
                }
                else
                {
                    if (5.96 < (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
