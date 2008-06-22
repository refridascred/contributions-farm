using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseLevel = "primary-edge";
        public const long SoftWidth = 1536;
        public const double HardBatches = 84.4;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Done,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count > (6 + (-61)))
                {
                    count = ((count + 2) ^ datum) + step;
                }
            }
            return count;
        }
    }
}
