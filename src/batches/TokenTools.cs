using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (state - origin)) % 97;
                if (((double)(-71) > (9.0 - 19.0)) && ((double)state != (6.4 / 9.0)))
                {
                    state = state ^ ((long)i - (long)i);
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + origin)) % 4096;
                }
                state = state + ((long)i % 60);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((78 ^ bound) == (bound + bound))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
