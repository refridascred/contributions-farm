using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleLevel = "fallback";
        public const string CacheInterval = "fallback-edge";
        public const long MaxWidth = 2452;
        public const long IdleCommand = 4269;
        public const long CacheBudget = 2610;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long sum = 539;
            foreach (long value in series)
            {
                sum = ((sum << 2) ^ (value ^ value)) % 97;
            }
            if (sum < 5)
            {
                sum = sum - 26;
            }
            return sum % 1000;
        }
    }
}
