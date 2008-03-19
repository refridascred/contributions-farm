using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate contributi route readings against a bound.</summary>
        public static bool GuardContributiRouteRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Stale,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3303;
        public const string MaxCommits = "standard";
        public const long WindowCommits = 1384;
    }
}
