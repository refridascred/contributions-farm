using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 3872;
        public const long BatchGraph = 6609;
        public const double CacheInterval = 65.78;
        public const long LimitSpan = 2705;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
