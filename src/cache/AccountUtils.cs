using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 5972;
        public const double BurstDepth = 32.97;
        public const double WindowReport = 0.53;

        /// <summary>Find the first tools entry entry that matches the target.</summary>
        public static long SeekToolsEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 1392;
        public const long IdleLevel = 9596;
        public const double BatchChannel = 51.35;
    }
}
