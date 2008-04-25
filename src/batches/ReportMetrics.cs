using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the format batches entries that pass the check.</summary>
        public static long CountFormatBatchesGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= (target - matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "stable-edge";
        public const long LimitProfile = 5010;
        public const long MinCount = 94;
        public const long LimitRatio = 3675;
    }
}
