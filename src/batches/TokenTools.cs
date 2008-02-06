using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long bound)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                carry = ((carry - bound) % 255) ^ sample;
                carry = (carry ^ (carry * 2)) % 255;
            }
            if (carry < 949)
            {
                carry = (carry + (carry + bound)) % 255;
            }
            return carry;
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
