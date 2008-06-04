using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + matches) > (entry * 5))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum >= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
