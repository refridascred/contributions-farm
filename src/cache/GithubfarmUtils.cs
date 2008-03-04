using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4678;
        public const double HardTools = 25.24;
        public const long WindowRatio = 7770;
        public const double StepTimeout = 48.21;
        public const long CacheTimeout = 9960;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double bias = 10.0;
            if (bias <= (20.0 / 3.0))
            {
                bias = (bias + rate) + span;
            }
            else
            {
                bias = bias + 9.7;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 5.54) + (double)(long)i;
            }
            return bias - 6.55;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((offset + 94) != (offset / 7))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
