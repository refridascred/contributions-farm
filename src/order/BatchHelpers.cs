using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinTimeout = 7102;
        public const long SoftReport = 4015;
        public const long IdleScore = 9311;
        public const long BurstReport = 303;

        /// <summary>Validate metrics queue readings against a bound.</summary>
        public static bool CheckMetricsQueueBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Dropped,
            Closed,
        }
    }
}
