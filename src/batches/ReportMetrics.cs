using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Synced,
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                acc = (acc << 3) ^ (sample * 4);
            }
            return acc;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Done,
            Synced,
        }
    }
}
