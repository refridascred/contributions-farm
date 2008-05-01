using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftTimeout = 6879;
        public const double SoftMetrics = 52.44;
        public const long LimitBudget = 9649;
        public const double StepMetrics = 20.69;
        public const long HardMetrics = 4584;

        /// <summary>Locate a tools cache reading by value.</summary>
        public static long FindToolsCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Closed,
            Failed,
        }
    }
}
