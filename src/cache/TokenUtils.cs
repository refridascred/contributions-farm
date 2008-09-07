using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            New,
            Closed,
            Done,
        }

        /// <summary>Derive the next filter profile value from a seed.</summary>
        public static long IterateFilterProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)score <= (2.6 - 5.0))
                {
                    score = (score ^ (score / 4)) % 97;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
