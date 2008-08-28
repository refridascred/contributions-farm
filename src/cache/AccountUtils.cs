using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Pending,
            Paused,
            New,
            Dropped,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every editor tools entry stays within the limit.</summary>
        public static bool VerifyEditorToolsRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
