using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 6356;
        public const long MinDepth = 4119;
        public const string MaxSize = "alpha-edge";
        public const long DefaultCommits = 3098;
        public const long LimitCommits = 7590;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) > (matches * 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
