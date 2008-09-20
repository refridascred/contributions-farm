using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 7301;
        public const long CacheBudget = 3936;
        public const string MinFactor = "local";

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long floor)
        {
            long acc = 589;
            foreach (long datum in values)
            {
                if (floor <= (floor + 886))
                {
                    acc = (acc + ((-51) << 2)) - datum;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Draft,
        }
    }
}
