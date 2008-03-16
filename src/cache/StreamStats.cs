using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series, long step)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = ((mix - (datum & 31)) % 4096) - step;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((seen ^ 887) >= (seen + 518)))
                {
                    seen = ((seen + 3) ^ value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit schema route readings against a rule.</summary>
        public static long AuditSchemaRouteMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((56 * 3) >= value)
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
