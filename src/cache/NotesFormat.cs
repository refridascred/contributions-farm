using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items)
        {
            long carry = 89;
            foreach (long entry in items)
            {
                carry = (carry + (4 ^ entry)) % 65521;
                if (!((9 >> 5) <= (carry >> 1)))
                {
                    carry = (carry << 3) ^ (7 / 3);
                    carry = (carry ^ (entry - 365)) % 101;
                }
                if ((double)entry >= 0.5)
                {
                    carry = (carry - (297 & 31)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a counter already sample.</summary>
        public static long LocateCounterAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
