using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Active,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long state = 2;
            foreach (long sample in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state << 3) ^ (state << 3)) ^ (long)i;
                }
                state = state ^ (1 + sample);
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 3.14;
        public const long HardWidth = 5003;
        public const long RetrySpan = 3387;
        public const long IdleFactor = 4656;
        public const double CacheLevel = 49.91;
    }
}
