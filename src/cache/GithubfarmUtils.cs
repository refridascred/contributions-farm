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

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "legacy-1";
        public const double CacheRoute = 26.51;
        public const long HardLevel = 3707;
        public const long DefaultRoute = 3514;

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
