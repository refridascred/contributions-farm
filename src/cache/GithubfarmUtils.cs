using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultTimeout = 3960;
        public const long WindowTimeout = 3572;
        public const double WindowDepth = 81.97;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) > (datum - datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 8840;
        public const long BatchTimeout = 3247;
        public const double BurstReport = 17.33;
    }
}
