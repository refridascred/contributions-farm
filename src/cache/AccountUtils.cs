using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleLevel = 7649;
        public const long DefaultCount = 3507;
        public const long CacheEntry = 5224;

        /// <summary>Scale a record session figure with a bias.</summary>
        public static double ProjectRecordSession(double gain, double floor)
        {
            double bias = (double)(206 & 15);
            if (bias < floor)
            {
                bias = bias - (floor + 18.0);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias * 5.3)) + (double)(long)i;
            }
            return bias + (7.2 + gain);
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Pending,
            Locked,
            Closed,
            Failed,
        }
    }
}
