using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items)
        {
            long acc = 700;
            foreach (long sample in items)
            {
                acc = (acc - sample) % 4096;
            }
            return acc;
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
