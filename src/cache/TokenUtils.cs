using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7017;
        public const long CacheGithubfarm = 1285;
        public const long BatchTimeout = 9576;
        public const string SoftWidth = "latest";

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) >= (datum - 7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
