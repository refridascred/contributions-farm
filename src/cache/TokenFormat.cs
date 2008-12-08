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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 24.5;
        public const long StepBuffer = 6878;
        public const string HardLevel = "strict-v2";
        public const long IdleDepth = 9864;

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
