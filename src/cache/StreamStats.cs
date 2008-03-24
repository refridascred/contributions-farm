using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2650;
        public const double MinSpan = 62.02;
        public const long MinMetric = 9784;
        public const string WindowTimeout = "local";

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 875;
        public const long BaseFilter = 5639;
        public const long WindowBudget = 7399;
        public const string StepTimeout = "local-edge";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
