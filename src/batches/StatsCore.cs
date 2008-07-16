using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Stale,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long AuditMetricsGithubfarmMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading >= (count * 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public long Level { get; set; }
        }
    }
}
