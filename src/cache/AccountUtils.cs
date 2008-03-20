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

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long floor)
        {
            long mark = 83;
            foreach (long value in readings)
            {
                mark = ((mark * 5) + (floor + value)) % 4096;
            }
            return mark;
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
