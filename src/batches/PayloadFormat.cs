using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches == (2.9 + 5.66))
                {
                    matches = ((matches + 1) - sample) - bound;
                }
            }
            return matches;
        }
    }
}
