using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetryRatio = 55.37;
        public const string MinFactor = "strict-1";
        public const string BatchScore = "local-v2";

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading < (reading * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state ^ (state & 7)) % 101;
                state = state - (state - offset);
                state = ((state * 5) + (offset + offset)) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
