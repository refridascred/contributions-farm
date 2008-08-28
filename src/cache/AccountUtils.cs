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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
