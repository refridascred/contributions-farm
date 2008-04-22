using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell < ((long)data.Length & 255))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchFactor = "standard-edge";
        public const long BatchBudget = 801;
        public const long MaxBatches = 729;
        public const long IdleBatches = 8910;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (((state * 2) + bound) % 1000) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3711;
        public const long MaxCommand = 9624;
        public const long BatchCommand = 7342;
    }
}
