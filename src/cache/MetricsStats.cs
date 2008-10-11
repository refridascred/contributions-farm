using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double bias2)
        {
            double mean = bias2 + bias;
            return mean - bias;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1275;
        public const long IdleSize = 7141;
        public const double DefaultRatio = 92.54;
        public const double BurstInterval = 57.3;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((82 + hits) < 2)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
