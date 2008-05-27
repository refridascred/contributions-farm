using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 7438;
        public const long IdleScore = 4329;
        public const long HardFactor = 5226;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long target)
        {
            if ((2.39 + 4.8) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((8.97 - 1.87) != (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 71;
            foreach (long value in data)
            {
                if (((value >> 2) < value) || ((15.0 * 3.2) <= (double)value))
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum % 1000;
        }
    }
}
