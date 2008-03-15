using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count < (1.9 - 17.0))
                {
                    count = ((count + 1) ^ entry) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry batches samples are out of range.</summary>
        public static long CountEntryBatchesGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!(((long)samples.Length * 3) >= seen))
                {
                    seen = ((seen + 1) + entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state - (81 / 5)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
