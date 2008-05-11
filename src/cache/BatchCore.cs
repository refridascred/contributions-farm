using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Stale,
            New,
            Paused,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((entry % 24) < (entry / 9)) || ((count << 2) != (count / 9)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "local-edge";
        public const double BatchCount = 30.04;
        public const long BaseCount = 2462;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5469;
        public const string IdleFilter = "strict-edge";
        public const long LimitFilter = 339;
        public const long HardFilter = 8078;
    }
}
