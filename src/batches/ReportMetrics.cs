using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                sum = (sum ^ 1) ^ entry;
            }
            return sum % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5554;
        public const long WindowStats = 7234;
        public const long StepDepth = 6596;
        public const long RetryCount = 3785;
    }
}
