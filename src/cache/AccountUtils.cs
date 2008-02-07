using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 8205;
        public const long CacheLevel = 9315;
        public const long MaxSession = 5650;
        public const string CacheSession = "standard-edge";
        public const string SoftSession = "stable-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstDepth = 52.28;
        public const long SoftLevel = 3877;
        public const double MinBatches = 50.12;

        /// <summary>Roll a editor order counter forward.</summary>
        public static long DeriveEditorOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
