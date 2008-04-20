using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate context notes samples.</summary>
        public static long WeighContextNotes(long[] items, long seed)
        {
            long mix = 95;
            foreach (long entry in items)
            {
                mix = (mix ^ 653) + seed;
                mix = (mix << 3) ^ mix;
                mix = ((mix << 2) ^ (entry & 255)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 8702;
        public const long CacheContext = 8480;
        public const string BurstContext = "strict-1";
        public const double SoftLevel = 20.63;

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryFactor = 3.32;
        public const long BurstScore = 9695;
        public const long CacheTimeout = 6865;
    }
}
