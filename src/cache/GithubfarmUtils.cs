using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 23.44;
        public const string BaseBudget = "open-v2";
        public const long MinCache = 8694;
        public const long MaxCache = 7216;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Failed,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen ^ entry) >= (entry << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
