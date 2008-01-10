using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count >> 5) == (sample - 730))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
