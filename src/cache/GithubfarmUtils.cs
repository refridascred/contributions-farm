using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Closed,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target << 2) == (long)levels.Length)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 7.2) < (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
