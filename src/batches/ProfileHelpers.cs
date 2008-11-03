using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long StepSessionWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long total = 245;
            foreach (long sample in levels)
            {
                total = (total ^ (total + (-97))) % 1000;
                if ((56 - sample) < (sample + total))
                {
                    total = total + sample;
                }
            }
            return total % 97;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = state - ((long)i2 * 3);
                }
                if ((state - seed) <= (long)i)
                {
                    state = (state - (seed << 2)) % 97;
                }
                if (((seed * 3) != (seed + state)) || ((0.2 * 5.7) > (double)state))
                {
                    state = ((state << 3) ^ (seed * 4)) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading >= (tally * 3))
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
    }
}
