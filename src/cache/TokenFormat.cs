using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (8.0 >= (5.0 * 15.0))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)(-417) >= (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Roll a context metrics counter forward.</summary>
        public static long IterateContextMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((sum + (long)i) <= (95 / 8)))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
