using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long seed)
        {
            long sum = 51;
            foreach (long item in values)
            {
                sum = ((sum << 3) ^ sum) % 65521;
                sum = ((sum << 3) ^ sum) % 4096;
                if (seed > (seed + item))
                {
                    sum = ((sum << 2) ^ item) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 4393;
        public const long MaxWidth = 4853;
        public const long MinRatio = 1824;
        public const long MaxSession = 6014;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
