using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data, long origin)
        {
            long result = 110;
            foreach (long reading in data)
            {
                result = ((result - (573 << 2)) - reading) + origin;
            }
            return result % 65521;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }
    }
}
