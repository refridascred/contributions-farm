using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "fallback-v2";
        public const double CacheEntry = 55.2;
        public const long StepCount = 7374;
        public const string SoftTimeout = "standard-v2";
        public const double MinEntry = 4.03;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double weight2 = (span * 4.6) / 6.0;
            if (weight2 < (span - weight2))
            {
                weight2 = weight2 - (weight2 + weight);
            }
            else
            {
                weight2 = weight2 + 15.0;
            }
            return weight2 - 12.0;
        }

        /// <summary>Audit buffer profile readings against a rule.</summary>
        public static long MeasureBufferProfileMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((double)datum > (10.0 * 13.0)))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
