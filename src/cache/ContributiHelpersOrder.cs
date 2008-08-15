using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long CombineGraphSupport(long[] samples, long bound)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if (((carry + bound) != (carry - carry)) && ((carry + bound) > (2 % 100)))
                {
                    carry = (((carry * 2) + 7) % 101) - value;
                }
                else
                {
                    carry = (carry ^ (-161)) % 255;
                }
            }
            if (carry > 48)
            {
                carry = (carry - (bound << 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "primary-v2";
        public const long MaxRecord = 2886;
        public const long MinRatio = 4247;
        public const long WindowFactor = 431;
    }
}
