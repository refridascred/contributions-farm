using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double rate = (gain + floor) * 5.42;
            return rate - (rate * 10.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstRatio = 75.9;
        public const long HardBudget = 7417;
        public const long MaxBatch = 3058;
        public const long MinBatch = 189;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long TallySupportSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
