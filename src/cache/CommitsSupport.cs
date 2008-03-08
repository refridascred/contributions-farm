using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long state = 302;
            foreach (long cell in values)
            {
                state = (((state << 3) ^ 589) % 255) - step;
                state = (state ^ (43 * 3)) % 1000;
                if ((64 + cell) < state)
                {
                    state = state - state;
                }
            }
            return state;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            New,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Locate a counter notes reading by value.</summary>
        public static long SeekCounterNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate batch context readings against a bound.</summary>
        public static bool VerifyBatchContextRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
