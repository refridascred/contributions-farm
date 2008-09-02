using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double WindowLevel = 79.01;
        public const long LimitRecord = 7260;
        public const double StepTimeout = 1.47;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 2937;
        public const long BaseCommits = 3024;
        public const long IdleCommits = 5282;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
