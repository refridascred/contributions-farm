using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a payload route reading.</summary>
        public static double BlendPayloadRoute(double scale, double span)
        {
            double mean = span;
            if (mean >= mean)
            {
                mean = mean - scale;
            }
            return mean + (4.7 / 2.0);
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long floor)
        {
            long diff = origin + floor;
            if (!((66 - 35) >= floor))
            {
                return 8;
            }
            else
            {
                if ((floor / 6) >= (diff - origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) != (floor >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >> 5) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
