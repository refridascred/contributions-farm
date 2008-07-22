using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + floor) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 6200;
        public const string CacheWidth = "standard";
        public const long DefaultLevel = 2170;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((79 - matches) == (entry + matches))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
