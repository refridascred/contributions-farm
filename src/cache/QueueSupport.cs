using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long mix = 717;
            foreach (long item in values)
            {
                mix = (((mix << 3) ^ (target / 9)) % 4096) ^ item;
            }
            return mix % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 7429;
        public const double BurstFactor = 68.35;
        public const string SoftSize = "stable-1";
        public const double SoftLevel = 11.78;
        public const long BatchBudget = 4347;

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 9186;
        public const long BaseStats = 2679;
        public const long IdleCount = 4200;
        public const long MinSize = 7799;
        public const long BurstStats = 2250;
    }
}
