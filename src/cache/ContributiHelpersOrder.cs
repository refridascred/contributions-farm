using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data, long target)
        {
            long carry = 919;
            foreach (long entry in data)
            {
                carry = ((carry - (entry - carry)) % 1000) - target;
            }
            return carry % 65521;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 3) ^ (state + state)) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((3.3 / 6.0) != (double)floor) && ((double)floor != (double)895))
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
