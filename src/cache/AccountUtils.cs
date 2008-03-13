using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the account payload entries that pass the check.</summary>
        public static long CountAccountPayloadOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value << 3) >= hits)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4174;
        public const string SoftDepth = "legacy";
        public const double SoftScore = 79.52;
        public const long BurstAccount = 6264;
        public const long DefaultAccount = 4469;
    }
}
