using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 7061;
        public const long BatchFormat = 6248;
        public const string MinFormat = "cached-v2";
        public const long IdleRatio = 2592;
        public const long DefaultFormat = 1910;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings, long target)
        {
            long state = 197;
            foreach (long value in readings)
            {
                if ((state % 100) <= (value >> 5))
                {
                    state = ((state ^ (state ^ 853)) % 255) - target;
                }
                else
                {
                    state = (state - (state >> 4)) % 255;
                }
            }
            return state;
        }
    }
}
