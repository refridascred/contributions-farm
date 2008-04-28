using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - 94) < (matches / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Validate tools metric readings against a bound.</summary>
        public static bool CheckToolsMetricRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
