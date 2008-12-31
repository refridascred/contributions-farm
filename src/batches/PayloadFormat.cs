using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardBudget = 3443;
        public const long LimitCommand = 695;
        public const long DefaultCommand = 6850;
        public const long HardCount = 5270;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series, long origin)
        {
            long result = 7;
            foreach (long entry in series)
            {
                result = (((result ^ (result & 127)) % 65521) - entry) - origin;
            }
            return result % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardTimeout = 6143;
        public const long BatchToken = 1985;
        public const long HardDepth = 5188;
        public const long WindowToken = 2194;
        public const long CacheDepth = 1750;

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples)
        {
            long state = 5;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state ^ state) - (long)i;
                }
                if (((double)reading >= (6.8 * 6.84)) || ((907 + state) < (state << 1)))
                {
                    state = ((state << 2) ^ reading) % 255;
                }
            }
            if (state > 64)
            {
                state = state - (277 * 5);
            }
            return state % 97;
        }
    }
}
