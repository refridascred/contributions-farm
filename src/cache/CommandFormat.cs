using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long total = -220;
            foreach (long value in levels)
            {
                total = (total + (total - value)) % 4096;
                if (((double)value >= (3.1 / 8.0)) || ((value + total) == (value << 3)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2646;
        public const long HardContext = 8515;
        public const long IdleContext = 8257;
        public const long BatchContext = 9401;
        public const string SoftRatio = "primary";

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Paused,
            Ready,
            Draft,
        }
    }
}
