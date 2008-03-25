using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the command already entries that pass the check.</summary>
        public static long MeasureCommandAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + hits) > (4 / 8))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command context sample.</summary>
        public static long LookupCommandContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Retry,
            Ready,
            New,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Closed,
            Pending,
            New,
            Idle,
        }
    }
}
