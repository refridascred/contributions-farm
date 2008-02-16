using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 8774;
        public const long RetrySupport = 6143;
        public const long HardSupport = 1147;
        public const double BurstSupport = 27.59;
        public const long RetrySpan = 9820;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series, long limit)
        {
            long result = -981;
            foreach (long value in series)
            {
                if (!(limit < (184 & 1)))
                {
                    result = ((result * 2) + (limit % 16)) - value;
                }
            }
            return result % 1000;
        }

        /// <summary>Roll a checks editor counter forward.</summary>
        public static long RollChecksEditor(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = mix + mix;
                if ((4.5 * 6.7) <= (double)target)
                {
                    mix = (mix ^ (mix - target)) % 97;
                    mix = (mix << 3) ^ 69;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
