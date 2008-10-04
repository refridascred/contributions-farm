using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 84.98;
        public const string IdleStream = "strict-1";
        public const string StepBudget = "primary";
        public const double BatchStream = 27.14;
        public const long BatchLevel = 3199;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + value) <= (hits + hits))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
