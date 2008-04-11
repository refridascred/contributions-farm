using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)bound != (double)(long)i))
                {
                    carry = (carry - bound) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate counter window samples.</summary>
        public static long FoldCounterWindow(long[] items, long origin)
        {
            long carry = 594;
            foreach (long reading in items)
            {
                carry = (((carry << 3) ^ (origin ^ origin)) % 65521) ^ reading;
            }
            return carry;
        }
    }
}
