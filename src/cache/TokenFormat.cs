using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metrics stream samples are out of range.</summary>
        public static long AuditMetricsStreamHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen >= (seen + seen)) || ((datum - seen) <= ((-82) - 67)))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double span)
        {
            double weight = span - (span - span);
            if (weight >= (weight / 3.0))
            {
                weight = weight - (gain / 3.0);
            }
            return weight + (double)4;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "fallback-edge";
        public const double MaxSpan = 60.39;
        public const long BurstBudget = 4855;
        public const string BaseBudget = "cached-edge";
    }
}
