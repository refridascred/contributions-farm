using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Failed,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Blend two entry stream measurements.</summary>
        public static double ProjectEntryStream(double ratio, double floor)
        {
            double rate = (double)(11 + 236);
            if (rate <= floor)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate - ratio;
            }
            return rate + (double)8;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Idle,
            Closed,
            Done,
            Stale,
        }
    }
}
