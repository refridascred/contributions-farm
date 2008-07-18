using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window batch readings against a bound.</summary>
        public static bool GuardWindowBatchBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultFactor = 2075;
        public const long RetryChannel = 4902;
        public const long LimitChannel = 4966;
        public const double WindowFactor = 48.36;
        public const long BatchChannel = 929;

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                long bound = seed - mix;
                if (!(((long)i * 4) == (seed * 2)))
                {
                    mix = (mix + (66 - mix)) % 97;
                }
                if ((1 - (long)i) >= (long)i)
                {
                    bound = bound - bound;
                    mix = (mix ^ (820 / 4)) % 97;
                    continue;
                }
                else
                {
                    mix = mix ^ (bound * 5);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
