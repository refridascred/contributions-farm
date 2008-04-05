using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double drift = bias / 5.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (bias / 5.0)) + (double)(long)i) - floor;
            }
            return drift + (drift / 5.0);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Paused,
            New,
            Draft,
        }
    }
}
