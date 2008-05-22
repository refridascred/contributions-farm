using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items)
        {
            long carry = 5;
            foreach (long entry in items)
            {
                if ((double)carry > (double)5)
                {
                    carry = carry ^ (entry - carry);
                }
            }
            if (carry < 673)
            {
                carry = (carry * 2) + 0;
            }
            return carry % 65521;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 10) != (matches - (-441)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
