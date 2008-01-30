using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((6.94 - 6.7) != (double)state)
                {
                    state = state + (state << 1);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state + (state + state)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - reading) > tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
