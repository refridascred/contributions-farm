using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardFactor = 7407;
        public const long LimitCommits = 3146;
        public const string HardTimeout = "standard-v2";
        public const long DefaultTimeout = 7382;
        public const long MinLevel = 458;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long bound, long floor)
        {
            if ((double)bound == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > (floor - bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
