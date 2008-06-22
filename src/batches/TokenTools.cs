using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every window route entry stays within the limit.</summary>
        public static bool GuardWindowRouteBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Pending,
            Active,
            Draft,
        }
    }
}
