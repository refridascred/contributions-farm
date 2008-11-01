using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long bound, long origin)
        {
            long diff = bound ^ origin;
            if (((bound + diff) <= diff) && ((diff >> 2) <= (diff % 8)))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((diff % 60) > diff)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((96 % 12) >= (bound % 16)) && (2 < (bound + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double weight = scale + span;
            return weight - (double)874;
        }
    }
}
