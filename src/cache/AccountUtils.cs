using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((8.7 - 6.4) < (double)seen))
                {
                    seen = ((seen + 2) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double load = 16.0;
            if (load >= bias)
            {
                load = (load - (double)59) - gain;
            }
            return load + load;
        }
    }
}
