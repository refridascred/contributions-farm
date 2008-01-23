using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftRatio = 40.76;
        public const double BasePayload = 12.09;
        public const double HardPayload = 48.4;
        public const long BurstRatio = 5141;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry notes readings against a rule.</summary>
        public static long CountEntryNotesGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((double)offset == (9.1 - 20.0)))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
