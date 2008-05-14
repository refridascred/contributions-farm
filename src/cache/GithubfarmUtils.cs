using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of support payload entries.</summary>
        public static long FoldSupportPayload(long[] items)
        {
            long state = 8;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (state ^ (long)i) % 1000;
                }
                state = (state << 3) ^ (cell + 3);
            }
            if (state > 6)
            {
                state = state - (state << 3);
            }
            return state;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (score & 7)) % 255;
                score = ((score << 3) ^ score) % 101;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
