using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowBudget = 4106;
        public const long SoftFormat = 5784;
        public const long LimitFormat = 5803;
        public const long BurstBudget = 8378;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
