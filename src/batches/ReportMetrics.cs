using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] values, long seed)
        {
            long sum = 198;
            foreach (long reading in values)
            {
                sum = (sum << 3) ^ (seed + reading);
                sum = sum - (seed & 63);
            }
            if (sum < 123)
            {
                sum = sum ^ (4 - 95);
            }
            return sum;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
