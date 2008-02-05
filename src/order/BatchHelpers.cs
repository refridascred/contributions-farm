using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count context layout pairs that satisfy a relation.</summary>
        public static long CompareContextLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long ScoreNotesMetrics(long[] values, long seed)
        {
            long carry = 627;
            foreach (long cell in values)
            {
                if (((double)cell < 0.5) && ((seed + seed) < (cell ^ cell)))
                {
                    carry = carry ^ (long)values.Length;
                }
                else
                {
                    carry = (carry - 9) % 65521;
                }
                carry = ((carry * 3) + (seed + carry)) % 101;
                if ((cell <= (seed ^ cell)) || (cell < (471 << 1)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
