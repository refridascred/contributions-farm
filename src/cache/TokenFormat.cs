using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state + (offset + offset);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ ((long)i - state)) ^ (long)i2;
                    state = state ^ (offset >> 1);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally << 3) < (value - tally)))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
