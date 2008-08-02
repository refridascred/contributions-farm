using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 4801;
        public const double BatchDepth = 73.51;
        public const long BurstStream = 6410;
        public const string CacheStream = "latest-edge";
        public const long HardCount = 1643;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 < gain)
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + (double)572;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Queued,
            Dropped,
            Retry,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5030;
        public const long RetryQueue = 2912;
        public const long WindowQueue = 488;
        public const double BaseRatio = 31.29;
        public const long MinQueue = 5756;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
