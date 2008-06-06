using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every cache githubfarm entry stays within the limit.</summary>
        public static bool GuardCacheGithubfarmBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Retry,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((((step + matches) != (568 & 127)) || ((double)datum > (double)98)) && (47 > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
