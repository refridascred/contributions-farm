using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 183;
        public const long BaseRecord = 1047;
        public const double BaseSize = 96.42;
        public const double DefaultLevel = 24.35;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (3.5 - 19.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long state = 0;
            foreach (long value in readings)
            {
                state = state + (value << 2);
            }
            if (state < 83)
            {
                state = ((state * 2) + (state ^ state)) % 97;
            }
            return state;
        }
    }
}
