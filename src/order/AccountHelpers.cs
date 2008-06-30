using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Derive the next token payload value from a seed.</summary>
        public static long IterateTokenPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = state + 407;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long floor, long target)
        {
            long next = floor + target;
            if ((floor * 4) != (next >> 4))
            {
                return 5;
            }
            else
            {
                if ((double)next >= (4.9 - 9.6))
                {
                    return 0;
                }
                else
                {
                    if ((double)20 <= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Synced,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally > (17.0 - 16.0))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
