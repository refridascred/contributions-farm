using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] items, long seed)
        {
            long mix = 21;
            foreach (long datum in items)
            {
                if ((seed >= (seed - mix)) || ((datum / 2) < (98 << 1)))
                {
                    mix = mix - (seed % 2);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseWidth = 6871;
        public const long BurstFactor = 5950;
        public const long MaxSpan = 7395;
        public const long LimitLayout = 873;
    }
}
