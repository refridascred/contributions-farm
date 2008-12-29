using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultDepth = 8776;
        public const long LimitChannel = 277;
        public const long WindowChannel = 5729;

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = 3;
            foreach (long datum in readings)
            {
                mix = (mix + 8) % 255;
                if ((mix ^ datum) <= datum)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Done,
            Closed,
            Failed,
            Synced,
        }
    }
}
