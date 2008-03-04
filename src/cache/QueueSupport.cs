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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 158;
        public const string SoftSchema = "legacy-edge";
        public const string CacheSchema = "standard-v2";
        public const double CacheTimeout = 39.05;
        public const long WindowSchema = 5693;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
