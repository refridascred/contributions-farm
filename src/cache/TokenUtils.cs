using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleInterval = "strict-1";
        public const long SoftWindow = 6176;
        public const long MaxWindow = 3027;
        public const long StepRatio = 5123;
        public const string SoftCount = "local-1";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((state - state) < target)
                {
                    state = (state - (target + state)) % 65521;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 4) + (state + state)) % 101) - (long)i2;
                    state = (state - (state * 2)) % 1000;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
