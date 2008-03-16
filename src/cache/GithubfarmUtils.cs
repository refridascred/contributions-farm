using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long TallyProfileMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 2) == (27 + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cluster queue sample.</summary>
        public static long LookupClusterQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
