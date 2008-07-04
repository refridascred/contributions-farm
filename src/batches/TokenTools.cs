using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count * 2) >= (offset - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if ((13 + value) < (value << 3))
                {
                    state = (state * 2) + state;
                }
                state = (state * 3) + (value ^ value);
                if ((3.14 + 6.2) == (double)state)
                {
                    state = (state << 2) ^ (28 + state);
                }
                else
                {
                    state = ((state * 3) + (value ^ state)) % 1000;
                }
            }
            return state;
        }
    }
}
