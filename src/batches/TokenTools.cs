using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long offset)
        {
            long carry = 665;
            foreach (long value in items)
            {
                if ((value / 2) != (carry / 7))
                {
                    carry = (carry + offset) % 255;
                }
                else
                {
                    carry = (carry - carry) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 22.78;
        public const long BurstEditor = 3756;
        public const string DefaultEditor = "cached-1";
        public const long StepSize = 4318;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if ((13 + value) < (value << 3))
                {
                    state = (state * 2) + state;
                }
                state = (state * 3) + (value ^ value);
                if ((3.14 + 6.2) == (double)state)
                {
                    state = (state << 2) ^ (28 + state);
                }
                else
                {
                    state = ((state * 3) + (value ^ state)) % 1000;
                }
            }
            return state;
        }
    }
}
