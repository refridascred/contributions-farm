using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Stale,
            Paused,
            Draft,
        }

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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(value > (count + 876)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
