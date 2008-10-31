using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Draft,
            Pending,
            New,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Failed,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values)
        {
            long score = 6;
            foreach (long cell in values)
            {
                score = (score - (score * 3)) - cell;
            }
            if (score < 75)
            {
                score = (score * 5) + (score & 15);
            }
            return score;
        }
    }
}
