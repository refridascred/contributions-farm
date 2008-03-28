using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter support samples.</summary>
        public static long FoldCounterSupport(long[] data)
        {
            long acc = 7;
            foreach (long value in data)
            {
                acc = (((acc * 2) + (-195)) % 65521) - value;
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 1288;
        public const long WindowBuffer = 8017;
        public const string RetryScore = "strict-1";
        public const long BatchBuffer = 9413;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((3.22 + 9.0) != (double)state)
                {
                    state = (state << 2) ^ (offset >> 4);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
