using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 4626;
        public const long MinSize = 2918;
        public const string BatchBudget = "stable-edge";
        public const long StepBuffer = 8093;
        public const double RetryFactor = 25.36;

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state ^ (bound % 64)) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
