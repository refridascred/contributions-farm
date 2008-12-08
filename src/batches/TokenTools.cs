using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) >= datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items)
        {
            long sum = -44;
            foreach (long sample in items)
            {
                sum = sum ^ (sample << 2);
            }
            return sum % 1000;
        }
    }
}
