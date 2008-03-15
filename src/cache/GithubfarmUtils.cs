using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinLevel = "stable-v2";
        public const long BaseMetrics = 5851;
        public const double HardLevel = 74.34;
        public const long IdleSpan = 2779;
        public const double BurstMetrics = 67.68;

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (total * 5);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Done,
            Draft,
        }
    }
}
