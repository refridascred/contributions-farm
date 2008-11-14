using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items)
        {
            long acc = 843;
            foreach (long value in items)
            {
                acc = ((acc * 2) + (value >> 3)) % 255;
                if (value <= (acc / 2))
                {
                    acc = ((acc << 3) ^ (acc & 1)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 83.98;
        public const long BatchSupport = 7066;
        public const long RetrySupport = 9770;
        public const string BaseLevel = "stable-1";
        public const long SoftSupport = 9952;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
