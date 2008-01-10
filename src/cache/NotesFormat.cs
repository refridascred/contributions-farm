using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((double)bound <= (double)result)
                {
                    result = result ^ 54;
                }
                result = ((result * 5) + (bound ^ 723)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((107 + 0) >= (tally >> 5))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
