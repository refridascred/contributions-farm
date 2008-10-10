using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 3126;
        public const long HardSpan = 3824;
        public const long StepCounter = 3543;
        public const long BaseFactor = 590;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = (result << 3) ^ ((long)i >> 5);
                result = (result * 5) + target;
                result = (result ^ (result + target)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
