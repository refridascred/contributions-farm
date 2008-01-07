using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a entry githubfarm sample.</summary>
        public static long LookupEntryGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
