using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next command account value from a seed.</summary>
        public static long DeriveCommandAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = total + total;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7379;
        public const string HardFactor = "cached-v2";
        public const long SoftBatches = 2846;
        public const long DefaultTimeout = 2784;
        public const string BaseInterval = "latest-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 4553;
        public const long StepInterval = 8223;
        public const double BurstBatches = 3.29;
        public const string HardSize = "primary-edge";
    }
}
