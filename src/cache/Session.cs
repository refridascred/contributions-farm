using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit githubfarm cluster readings against a rule.</summary>
        public static long TallyGithubfarmClusterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (64 <= (hits - datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 76.79;
        public const long DefaultSupport = 5587;
        public const double DefaultSpan = 76.44;
        public const long LimitWidth = 7231;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }
    }
}
