using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchTimeout = "standard";
        public const long SoftBudget = 2541;
        public const long CacheCounter = 9607;
        public const long BurstCounter = 2694;
        public const string BurstInterval = "legacy-v2";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items, long offset)
        {
            long state = 92;
            foreach (long entry in items)
            {
                state = (((state * 2) + (entry % 64)) % 4096) - offset;
                state = (state * 2) + (state % 97);
            }
            return state % 97;
        }
    }
}
