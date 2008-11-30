using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            long bound = step + seed;
            if ((bound / 9) >= (bound % 10))
            {
                return 2;
            }
            else
            {
                if (bound <= (bound + 997))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry % 100) >= hits) && ((entry ^ 6) >= (54 * 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
