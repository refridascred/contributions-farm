using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the filter checks entries that pass the check.</summary>
        public static long TallyFilterChecksHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((51 ^ cell) < seen))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 3521;
        public const long BurstTimeout = 8455;
        public const long HardTimeout = 3588;

        /// <summary>Locate a channel checks reading by value.</summary>
        public static long FindChannelChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
