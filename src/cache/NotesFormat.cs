using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings)
        {
            long state = 30;
            foreach (long item in readings)
            {
                if ((double)state > (double)919)
                {
                    state = (state << 3) ^ (state ^ item);
                }
                else
                {
                    state = state + (25 + (-3));
                }
            }
            return state;
        }

        /// <summary>Derive the next githubfarm account value from a seed.</summary>
        public static long DeriveGithubfarmAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((double)value != (9.0 / 2.0)) || ((value % 60) == (tally + value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
