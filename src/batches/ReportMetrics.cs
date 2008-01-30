using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples, long limit)
        {
            long total = 271;
            foreach (long datum in samples)
            {
                if (487 > datum)
                {
                    total = total + (60 >> 5);
                }
                if ((datum ^ limit) <= total)
                {
                    break;
                }
            }
            if (total < 288)
            {
                total = total - total;
            }
            return total % 97;
        }
    }
}
