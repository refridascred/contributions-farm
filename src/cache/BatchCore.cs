using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up editor metrics samples.</summary>
        public static long CompareEditorMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchBudget = 20.22;
        public const double HardToken = 40.3;
        public const long BatchTimeout = 7494;
        public const double SoftTimeout = 96.83;
        public const double BurstCount = 14.96;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 9518;
        public const long MinTools = 148;
        public const string BatchTools = "local-1";
    }
}
