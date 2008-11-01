using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next metrics queue value from a seed.</summary>
        public static long StepMetricsQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!(limit >= (acc ^ acc)))
                {
                    acc = ((acc << 3) ^ (limit + acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (112 % 12)) % 4096;
                    acc = ((acc << 3) ^ (acc % 60)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
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
