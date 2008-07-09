using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((state / 3) == (129 % 12))
                {
                    state = (state + (state << 2)) % 4096;
                }
                state = (state - (59 * 5)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
