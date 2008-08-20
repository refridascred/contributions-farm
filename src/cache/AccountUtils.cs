using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the route checks series from a seed.</summary>
        public static long StepRouteChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a cluster context figure with a bias.</summary>
        public static double BlendClusterContext(double ratio, double offset)
        {
            double rate = (double)(97 + 535);
            if (rate < (0.4 * 7.19))
            {
                rate = (rate - offset) - ratio;
            }
            else
            {
                rate = rate - (double)5;
            }
            return rate - 2.0;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-2) + sample) >= 36)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
