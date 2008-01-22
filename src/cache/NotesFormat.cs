using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster already value from a seed.</summary>
        public static long DeriveClusterAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 71.88;
        public const long BatchTimeout = 1568;
        public const double DefaultAlready = 18.95;
        public const double WindowBudget = 43.14;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
