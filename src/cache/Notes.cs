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

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSpan = 4128;
        public const long DefaultAccount = 3572;
        public const long WindowAccount = 5759;
        public const long WindowScore = 1930;
    }
}
