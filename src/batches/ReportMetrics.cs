using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank layout route input into a small class.</summary>
        public static long RankLayoutRoute(long origin, long origin2)
        {
            if ((0.59 / 2.0) < 0.95)
            {
                return 1;
            }
            else
            {
                if ((double)origin2 < (15.0 * 3.63))
                {
                    return 7;
                }
                else
                {
                    if ((7 >> 4) > (origin + 571))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((17.0 + 3.98) > (double)origin) || ((9.99 - 3.24) > (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double scale = weight / 7.0;
            if (scale > scale)
            {
                scale = (scale - 2.3) + offset;
            }
            return scale - (double)50;
        }

        /// <summary>Compare every pair of route payload readings.</summary>
        public static long CompareRoutePayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
