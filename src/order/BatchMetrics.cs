using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (1 <= (item - item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count account counter pairs that satisfy a relation.</summary>
        public static long PairAccountCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "standard-edge";
        public const string HardSpan = "alpha-edge";
        public const long LimitSize = 7483;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Retry,
            Queued,
            Locked,
        }
    }
}
