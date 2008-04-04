using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - 7) % 97) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardBudget = 2180;
        public const string SoftWidth = "staging";
        public const long DefaultTimeout = 3481;
        public const long HardOrder = 5366;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Size { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
