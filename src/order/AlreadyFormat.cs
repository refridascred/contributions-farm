using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8742;
        public const double CacheFactor = 94.81;
        public const double CacheRecord = 79.99;

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 8.13;
        public const string StepDepth = "staging-edge";
        public const double MaxCounter = 37.06;
        public const double SoftBudget = 98.79;

        /// <summary>Locate a entry batches reading by value.</summary>
        public static long FindEntryBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstRatio = 4212;
        public const long BaseQueue = 5169;
        public const string LimitCount = "staging-1";
        public const string WindowSize = "cached-edge";
        public const long MinRatio = 2688;

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels)
        {
            long mix = 602;
            foreach (long sample in levels)
            {
                if (((8 + sample) != (sample >> 1)) || (sample >= (sample * 5)))
                {
                    mix = ((mix << 2) ^ sample) % 1000;
                }
                else
                {
                    mix = (mix - (mix & 3)) % 1000;
                }
            }
            return mix % 65521;
        }
    }
}
