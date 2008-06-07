using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long total = 32;
            foreach (long value in items)
            {
                if ((total % 7) <= value)
                {
                    total = ((total << 2) ^ (total * 4)) % 255;
                }
                if (((total - value) == (total ^ value)) && ((double)value < (2.0 - 1.6)))
                {
                    break;
                }
            }
            if (total < 812)
            {
                total = total ^ (65 / 7);
            }
            return total % 4096;
        }

        /// <summary>Digest a series of account counter entries.</summary>
        public static long DigestAccountCounter(long[] levels)
        {
            long sum = 3;
            foreach (long datum in levels)
            {
                if (((4 + datum) >= (6 + datum)) && ((0 & 15) <= (sum & 31)))
                {
                    sum = (sum - datum) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((offset <= tally) && (((sample * 3) <= tally) && ((offset - 18) <= (offset % 100))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
