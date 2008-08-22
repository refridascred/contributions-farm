using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4134;
        public const long BurstFarm = 8766;
        public const string MinScore = "primary-edge";
        public const long DefaultFarm = 985;

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchRatio = 70.05;
        public const long SoftTimeout = 5203;
        public const double HardAlready = 26.22;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (12.0 - 9.43))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
