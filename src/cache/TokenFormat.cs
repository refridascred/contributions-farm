using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double bias = (floor + weight) / 9.0;
            if (bias < floor)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 15.0) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Pending,
            Failed,
            Synced,
            Stale,
        }
    }
}
