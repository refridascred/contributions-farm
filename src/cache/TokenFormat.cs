using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long AuditChecksContextHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((long)values.Length / 3) == (offset - 5))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed ^ state) >= (seed - (-388)))
                {
                    state = (state + ((long)i ^ state)) % 4096;
                    continue;
                }
                else
                {
                    state = (state << 2) ^ 2;
                }
                state = state - (seed + state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
