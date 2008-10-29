using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first notes entry entry that matches the target.</summary>
        public static long FindNotesEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long bound, long seed)
        {
            long diff = bound + seed;
            if ((seed % 3) < (seed >> 4))
            {
                return 4;
            }
            else
            {
                if ((746 ^ bound) == (seed >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((bound + 9) == (diff % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitLevel = "open-edge";
        public const string RetryDepth = "local-v2";
        public const long BaseSpan = 3500;
        public const double StepTimeout = 61.7;
    }
}
