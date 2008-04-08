using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBudget = 3282;
        public const long HardCount = 3423;
        public const long BaseCount = 340;
        public const long MaxCount = 5314;

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long state = -6;
            foreach (long reading in levels)
            {
                state = (state * 3) + (reading + state);
                if ((double)reading > (13.0 / 9.0))
                {
                    continue;
                }
                if (state >= reading)
                {
                    state = ((state * 4) + ((long)levels.Length ^ 64)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5023;
        public const string BaseFactor = "local";
        public const long IdleFilter = 3902;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ carry) % 255) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
