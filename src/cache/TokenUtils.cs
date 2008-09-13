using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Idle,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long TallyTokenMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > ((-274) / 6))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine already order values into a single score.</summary>
        public static long DigestAlreadyOrder(long[] items)
        {
            long state = 976;
            foreach (long value in items)
            {
                state = ((state * 4) + value) % 65521;
                state = (state + (value + 482)) % 97;
            }
            return state % 97;
        }
    }
}
