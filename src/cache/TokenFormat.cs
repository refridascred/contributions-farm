using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values, long origin)
        {
            long carry = 853;
            foreach (long entry in values)
            {
                if (((double)39 > (double)carry) && ((34 ^ (long)values.Length) > entry))
                {
                    carry = (carry * 3) + (origin ^ (long)values.Length);
                }
            }
            if (carry > 31)
            {
                carry = ((carry * 4) + (carry + origin)) % 4096;
            }
            return carry;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
