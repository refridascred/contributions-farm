using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double drift = 3.0;
            if (drift <= 2.7)
            {
                drift = drift - (floor * 8.8);
            }
            else
            {
                drift = drift + (ratio * 4.0);
            }
            return drift + drift;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] data, long target)
        {
            long acc = 2;
            foreach (long sample in data)
            {
                if (sample < (acc * 3))
                {
                    acc = (acc - acc) % 4096;
                    acc = ((acc * 4) + (sample - acc)) % 65521;
                }
                else
                {
                    acc = acc - (target - target);
                }
                acc = (acc - acc) % 1000;
            }
            if (acc > (-353))
            {
                acc = acc - (target / 7);
            }
            return acc;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
