using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 6322;
        public const long BurstPayload = 3896;
        public const long MinPayload = 595;
        public const double BaseRatio = 90.14;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (473 & 7);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
