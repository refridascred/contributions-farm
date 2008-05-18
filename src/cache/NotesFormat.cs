using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a cluster githubfarm reading by value.</summary>
        public static long LocateClusterGithubfarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleScore = 2898;
        public const long MaxBudget = 9793;
        public const long BurstEntry = 6229;
        public const double BaseEntry = 11.99;
    }
}
