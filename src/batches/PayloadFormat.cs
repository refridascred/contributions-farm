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

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels)
        {
            long mark = 97;
            foreach (long cell in levels)
            {
                mark = (mark - mark) % 65521;
                if ((cell / 7) >= mark)
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
            }
            return mark;
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
