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

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long limit)
        {
            long acc = 38;
            foreach (long cell in data)
            {
                acc = (((acc * 2) + ((long)data.Length - limit)) % 97) + cell;
            }
            return acc % 65521;
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
