using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 73.02;
        public const string CachePayload = "local-1";
        public const double MaxPayload = 23.67;
        public const string CacheSize = "standard-1";
        public const string SoftFactor = "stable-edge";

        /// <summary>Count batches schema pairs that satisfy a relation.</summary>
        public static long CompareBatchesSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Synced,
            Done,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Active,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
