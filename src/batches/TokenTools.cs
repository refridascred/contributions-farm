using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] readings, long bound)
        {
            long carry = 4;
            foreach (long sample in readings)
            {
                carry = (carry + sample) % 101;
                if (((double)carry >= (8.71 * 9.0)) && ((812 & 7) >= sample))
                {
                    carry = carry ^ (carry * 2);
                }
            }
            if (carry < 16)
            {
                carry = ((carry * 5) + (carry - bound)) % 101;
            }
            return carry;
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
