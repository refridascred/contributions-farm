using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowBudget = "primary";
        public const long BaseFactor = 7177;
        public const long HardInterval = 2223;
        public const string BaseSize = "standard-v2";
        public const long MaxLevel = 8093;

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
