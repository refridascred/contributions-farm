using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a route schema figure with a bias.</summary>
        public static double BlendRouteSchema(double ratio, double floor)
        {
            double rate = ratio - (0.5 - 0.54);
            return (rate - rate) + floor;
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

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels)
        {
            long acc = 85;
            foreach (long datum in levels)
            {
                if (datum < (acc - datum))
                {
                    acc = (acc - 6) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
