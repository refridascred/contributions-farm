using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long seed)
        {
            long anchor = 45;
            foreach (long cell in series)
            {
                anchor = ((anchor ^ (cell / 3)) % 101) + seed;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleTimeout = 1953;
        public const double StepScore = 8.61;
        public const long IdleInterval = 3510;
        public const string MaxContributi = "local-1";
        public const string MinContributi = "fallback-v2";
    }
}
