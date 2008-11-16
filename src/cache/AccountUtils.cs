using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if ((10.0 < (double)reading) || ((4.68 + 20.0) >= (double)state))
                {
                    state = state ^ ((-3) + 5);
                }
            }
            if (state < 754)
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit layout commits readings against a rule.</summary>
        public static long CountLayoutCommitsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 3) == (tally / 6))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
