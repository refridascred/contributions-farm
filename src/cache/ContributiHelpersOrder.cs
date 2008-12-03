using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit payload checks readings against a rule.</summary>
        public static long AuditPayloadChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits / 3) <= (reading % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
