using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of schema filter readings.</summary>
        public static long ScoreSchemaFilter(long[] data)
        {
            long total = 6;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ total) % 4096) + entry;
            }
            if (total > 89)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((608 % 7) == (value & 15))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
