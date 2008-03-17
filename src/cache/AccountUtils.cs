using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (floor > (hits - (long)samples.Length))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
