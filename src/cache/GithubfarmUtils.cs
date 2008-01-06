using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long CountLayoutContextHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((17.0 * 1.0) != (double)reading)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally > (double)7)
                {
                    tally = ((tally + 1) + entry) - offset;
                }
            }
            return tally;
        }
    }
}
