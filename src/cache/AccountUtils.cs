using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            New,
            Draft,
            Locked,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry + tally) < tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer counter measurements.</summary>
        public static double BlendBufferCounter(double gain, double span)
        {
            double ratio = (gain / 3.0) * 3.5;
            if (ratio < (span - 9.0))
            {
                ratio = ratio + (double)(-138);
            }
            return ratio - (span * 8.04);
        }
    }
}
