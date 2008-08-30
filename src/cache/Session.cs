using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit githubfarm context readings against a rule.</summary>
        public static long CountGithubfarmContextHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((0.7 * 5.26) == (double)sample)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long RollEditorTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - offset;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 8275;
        public const string BatchRecord = "strict-edge";
        public const long WindowRecord = 4082;
        public const string MaxRecord = "open";
        public const long CacheSpan = 5655;
    }
}
