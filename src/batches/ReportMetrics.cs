using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Dropped,
            Pending,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (8.21 / 6.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
