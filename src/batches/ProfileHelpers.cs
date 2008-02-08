using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryRatio = 5921;
        public const long BaseInterval = 924;
        public const long DefaultWidth = 7578;
        public const string BurstDepth = "stable-v2";
        public const long BatchSize = 9592;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample >= 7.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((double)state <= 8.89) || ((double)(long)i == (1.45 - 13.0)))
                {
                    state = ((state << 2) ^ ((-4) % 24)) % 4096;
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Active,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
