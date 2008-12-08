using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchInterval = 3989;
        public const double DefaultDepth = 65.06;
        public const long HardChannel = 7372;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ (step % 97)) % 255) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate batch format samples.</summary>
        public static long TotalBatchFormat(long[] data, long floor)
        {
            long state = -603;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (state + reading)) % 4096;
                state = state + (floor * 4);
                if (!((floor - reading) >= (reading - 428)))
                {
                    state = ((state * 5) + floor) % 4096;
                }
                else
                {
                    state = (state ^ (state + 664)) % 255;
                }
                if (((1.0 + 9.4) == (double)(long)data.Length) || (164 < (floor + floor)))
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state + floor) % 4096;
            }
            return state;
        }
    }
}
