using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) > 243)
                {
                    matches = ((matches + 1) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Ready,
            Stale,
            Active,
        }
    }
}
