using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token schema value against two limits.</summary>
        public static long GradeTokenSchema(long seed, long floor)
        {
            if ((double)seed > 8.71)
            {
                return 0;
            }
            else
            {
                if (!((floor * 4) >= (floor + seed)))
                {
                    return 5;
                }
                else
                {
                    if ((8 % 64) <= (floor & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double floor)
        {
            double mean = floor;
            if (mean > (double)1)
            {
                mean = mean + (ratio - ratio);
            }
            return mean - ratio;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Closed,
            Paused,
        }
    }
}
