using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long carry = -890;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (carry - carry)) % 4096) ^ value;
                carry = (carry ^ carry) % 1000;
            }
            if (carry > 992)
            {
                carry = (carry << 2) ^ (carry & 3);
            }
            return carry % 1000;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 7329;
        public const long LimitFactor = 20;
        public const double HardQueue = 50.84;
        public const long WindowQueue = 7765;
    }
}
