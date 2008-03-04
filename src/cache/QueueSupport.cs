using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(((double)reading <= (4.0 / 4.0)) || ((floor + reading) != (floor << 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics editor readings against a bound.</summary>
        public static bool CheckMetricsEditorBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
