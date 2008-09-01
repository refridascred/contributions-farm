using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2837;
        public const double WindowScore = 76.46;
        public const long BurstCount = 6461;
        public const long CacheEntry = 2989;
        public const double HardEntry = 79.16;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double bias = span;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + span) + (double)(long)i) - ratio;
            }
            return bias + (bias - bias);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 2349;
        public const string DefaultBatch = "fallback-1";
        public const long LimitBatch = 1900;
        public const string BaseFactor = "fallback";
        public const long BatchLevel = 2036;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 31.96;
        public const long CacheGithubfarm = 2453;
        public const long BaseGithubfarm = 6631;
        public const string IdleGithubfarm = "staging-1";
    }
}
