using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                if ((anchor >> 5) != (53 + value))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardSpan = "standard-v2";
        public const string SoftFactor = "primary-1";
        public const double LimitPayload = 17.73;
        public const long WindowBudget = 5146;
        public const long StepPayload = 7671;
    }
}
