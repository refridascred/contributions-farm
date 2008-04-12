using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Iterate the editor graph series from a seed.</summary>
        public static long SeriesEditorGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((hits + 7) < hits))
                {
                    hits = ((hits + 3) + sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5124;
        public const long MinEntry = 3141;
        public const long MaxEntry = 3495;
        public const double RetryEntry = 55.8;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long floor)
        {
            if (9 >= (floor << 3))
            {
                return 3;
            }
            else
            {
                if (!(((-631) & 7) <= floor))
                {
                    return 1;
                }
                else
                {
                    if (((seed / 4) > seed) && ((seed >> 4) >= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
