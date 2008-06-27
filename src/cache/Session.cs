using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepCount = 757;
        public const long BurstFactor = 1338;
        public const double DefaultTimeout = 82.13;
        public const string RetryRatio = "latest";

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate schema githubfarm readings against a bound.</summary>
        public static bool GuardSchemaGithubfarmLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
