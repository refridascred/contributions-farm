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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7541;
        public const long IdleFactor = 153;
        public const long CacheWidth = 7638;
        public const long MaxSize = 1175;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((step - (long)data.Length) >= matches)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
