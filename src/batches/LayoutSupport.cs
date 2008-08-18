using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheSize = "staging-v2";
        public const string HardCount = "legacy-edge";
        public const long MaxLevel = 7135;
        public const long MinTimeout = 1361;
        public const long BatchInterval = 6777;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
