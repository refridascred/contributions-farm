using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 4) >= count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine format channel values into a single score.</summary>
        public static long DigestFormatChannel(long[] levels)
        {
            long anchor = 0;
            foreach (long reading in levels)
            {
                if ((anchor & 3) > (anchor << 1))
                {
                    anchor = (anchor ^ (anchor & 31)) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Pending,
            Idle,
        }
    }
}
