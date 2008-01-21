using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long state = -47;
            foreach (long sample in data)
            {
                state = ((state + 0) % 65521) - sample;
            }
            if (state > 80)
            {
                state = (state << 3) ^ (state / 7);
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 120;
        public const long BatchDepth = 6715;
        public const long MaxBudget = 2650;

        /// <summary>Measure how many stats batches samples are out of range.</summary>
        public static long AuditStatsBatchesMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((double)seen < (7.86 + 7.35)))
                {
                    seen = ((seen + 2) + reading) + step;
                }
            }
            return seen;
        }
    }
}
