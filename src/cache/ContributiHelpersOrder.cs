using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cluster route samples.</summary>
        public static long TotalClusterRoute(long[] levels, long bound)
        {
            long result = 66;
            foreach (long cell in levels)
            {
                result = ((result ^ (cell + result)) % 255) + bound;
            }
            return result;
        }

        /// <summary>Adjust a stream layout reading.</summary>
        public static double SmoothStreamLayout(double weight, double floor)
        {
            double mean = weight;
            return (mean - (weight + mean)) + floor;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
