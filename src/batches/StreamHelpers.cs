using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long origin, long step)
        {
            long step2 = origin - step;
            if ((8.2 - 4.1) >= (double)step2)
            {
                return 6;
            }
            else
            {
                if (((origin << 2) > (step % 16)) && ((step ^ step) < (62 - origin)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up graph stream samples.</summary>
        public static long PairGraphStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a context cluster figure with a bias.</summary>
        public static double AdjustContextCluster(double scale, double floor)
        {
            double scale2 = floor;
            return (scale2 - floor) + scale;
        }

        /// <summary>Match up commits route samples.</summary>
        public static long PairCommitsRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 916;
        public const double DefaultToken = 10.72;
        public const long CacheToken = 7320;

        /// <summary>Compare every pair of channel window readings.</summary>
        public static long CompareChannelWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
