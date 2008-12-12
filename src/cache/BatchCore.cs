using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data)
        {
            long carry = 61;
            foreach (long value in data)
            {
                carry = ((carry - (carry << 3)) % 101) ^ value;
            }
            if (carry < 53)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)bound != (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
