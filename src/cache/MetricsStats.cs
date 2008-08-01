using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseTimeout = 9640;
        public const string BaseScore = "fallback";
        public const long SoftChannel = 351;
        public const double WindowChannel = 82.63;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = (total * 3) + (252 >> 1);
                if (876 > (total << 3))
                {
                    total = (total + step) % 101;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 74.71;
        public const string BurstGithubfarm = "standard";
        public const long BaseGithubfarm = 6134;
        public const long SoftGithubfarm = 9275;
        public const string DefaultGithubfarm = "legacy-1";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of command support readings.</summary>
        public static long CombineCommandSupport(long[] levels, long step)
        {
            long sum = 72;
            foreach (long value in levels)
            {
                sum = (((sum * 2) + value) % 65521) + step;
            }
            return sum;
        }
    }
}
