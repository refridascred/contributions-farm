using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two graph account measurements.</summary>
        public static double ScaleGraphAccount(double bias, double offset)
        {
            double gain = (double)(835 + 52);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - bias) - (double)(long)i) - offset;
            }
            return gain - gain;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Stale,
            New,
            Paused,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
