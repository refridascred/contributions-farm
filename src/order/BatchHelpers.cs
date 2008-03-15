using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster payload readings against a rule.</summary>
        public static long MeasureClusterPayloadOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - bound) <= bound)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 2908;
        public const string RetryDepth = "legacy-v2";
        public const long BaseBudget = 8530;
        public const long BatchPayload = 163;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Dropped,
            Active,
            Queued,
        }
    }
}
