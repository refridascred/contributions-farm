using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            Synced,
            Ready,
            Locked,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchLevel = "cached-1";
        public const long DefaultGithubfarm = 462;
        public const long BaseGithubfarm = 9336;
        public const long StepSpan = 9108;
        public const double IdleGithubfarm = 48.49;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Draft,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
