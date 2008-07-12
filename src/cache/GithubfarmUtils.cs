using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series, long seed)
        {
            long acc = 530;
            foreach (long datum in series)
            {
                if (datum <= (acc - 3))
                {
                    acc = ((acc + (445 & 255)) % 65521) + seed;
                }
                if (datum > (long)series.Length)
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = (acc + (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Active,
            Draft,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
