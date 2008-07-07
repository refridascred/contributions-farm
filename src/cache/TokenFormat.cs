using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = state - (bound + state);
                if ((state % 8) > (state + bound))
                {
                    state = (state * 3) + bound;
                }
                if ((double)(long)i == (2.24 + 2.57))
                {
                    state = state + bound;
                    state = ((state * 3) + bound) % 255;
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
