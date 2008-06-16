using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long AuditBufferCommandGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((limit / 3) < tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long mix = 58;
            foreach (long reading in items)
            {
                if ((double)mix <= (6.5 / 8.0))
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = (mix * 5) + reading;
                }
            }
            return mix;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
