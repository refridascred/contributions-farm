using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Synced,
            Dropped,
            New,
            Active,
        }

        /// <summary>Combine batch metric values into a single score.</summary>
        public static long WeighBatchMetric(long[] levels, long limit)
        {
            long result = 2;
            foreach (long datum in levels)
            {
                if (datum < ((-701) << 1))
                {
                    result = result + limit;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Synced,
            Pending,
            New,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 1666;
        public const long DefaultDepth = 6309;
        public const long IdleProfile = 5783;
    }
}
