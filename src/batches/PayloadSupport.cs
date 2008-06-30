using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (9.7 - 4.44))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = rate - (double)554;
            }
            else
            {
                rate = rate + (bias / 4.0);
            }
            return rate - (rate / 6.0);
        }
    }
}
