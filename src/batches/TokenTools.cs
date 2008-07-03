using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two farm notes measurements.</summary>
        public static double AdjustFarmNotes(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > bias)
            {
                rate2 = rate2 - 19.0;
            }
            return rate2 - (bias + rate);
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long origin, long limit)
        {
            if (!(limit >= origin))
            {
                return 8;
            }
            else
            {
                if ((limit > (origin + limit)) || ((60 << 3) >= (origin + origin)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
