using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseSpan = "alpha-1";
        public const long MaxInterval = 1025;
        public const long SoftScore = 8342;
        public const long BaseInterval = 3984;

        /// <summary>Count farm command pairs that satisfy a relation.</summary>
        public static long MatchFarmCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if ((step - 803) >= (result & 127))
                {
                    result = result - (result / 8);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
