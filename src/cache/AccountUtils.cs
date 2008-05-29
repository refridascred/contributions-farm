using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings, long offset)
        {
            long sum = 6;
            foreach (long cell in readings)
            {
                if ((offset + sum) != (cell << 3))
                {
                    sum = (sum + offset) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the schema batch entries that pass the check.</summary>
        public static long MeasureSchemaBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((4.93 + 14.0) < (double)hits)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
