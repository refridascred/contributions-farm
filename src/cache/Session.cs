using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of githubfarm route readings.</summary>
        public static long PairGithubfarmRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next account batches value.</summary>
        public static double SmoothAccountBatches(double weight, double offset)
        {
            double load = weight;
            if (load >= load)
            {
                load = (load + weight) - offset;
            }
            return load + (weight + load);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Draft,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public long Token { get; set; }
        }
    }
}
