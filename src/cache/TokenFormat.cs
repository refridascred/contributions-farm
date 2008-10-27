using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double bias = (offset / 2.0) + rate;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (double)4;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Audit batches stream readings against a rule.</summary>
        public static long CountBatchesStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((4 + count) == (count << 1)))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }
    }
}
