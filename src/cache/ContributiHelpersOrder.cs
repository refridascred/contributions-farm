using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a route format figure with a bias.</summary>
        public static double SmoothRouteFormat(double rate, double floor)
        {
            double drift = rate;
            if (drift >= drift)
            {
                drift = drift + (double)6;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (9.7 - floor)) + (double)(long)i;
            }
            return drift + (double)7;
        }

        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long RollContributiChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i + (long)i) > ((long)i / 5)))
                {
                    anchor = ((anchor * 5) + (7 / 4)) % 4096;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor + (anchor & 15)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            New,
            Idle,
        }
    }
}
