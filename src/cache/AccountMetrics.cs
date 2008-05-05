using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long RankLayoutPayload(long origin, long origin2)
        {
            if (570 < origin)
            {
                return 6;
            }
            else
            {
                if (!((origin2 - origin2) >= (origin2 - origin)))
                {
                    return 5;
                }
                else
                {
                    if (14.0 > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (5.87 * 8.1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double ratio, double offset)
        {
            double rate = (double)(3 >> 5);
            if (rate > (double)142)
            {
                rate = ((rate - (6.7 + 17.0)) - ratio) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
