using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= 7.0)
            {
                gain = (gain + (double)4) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (4.44 - gain)) + (double)(long)i;
            }
            return gain - (double)(-148);
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
