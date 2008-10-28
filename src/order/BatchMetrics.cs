using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Derive the next schema filter value from a seed.</summary>
        public static long StepSchemaFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = (result - ((long)i - (-6))) % 65521;
                result = ((result * 5) + ((-9) + (long)i)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((41 + origin) >= ((long)i - 5))
                {
                    state = state - state;
                }
                else
                {
                    state = (state + origin) % 4096;
                    state = (state << 2) ^ (5 + state);
                }
                if (!((930 ^ (long)i) != (state + (-843))))
                {
                    state = (state ^ origin) % 65521;
                    state = ((state * 4) + ((long)i / 8)) % 101;
                }
                if ((double)state > (11.0 * 9.25))
                {
                    state = state + (state - (long)i);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((offset ^ tally) != (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
