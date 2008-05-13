using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every route graph entry stays within the limit.</summary>
        public static bool GuardRouteGraphLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowLevel = "stable-1";
        public const string StepRatio = "alpha-1";
        public const long HardLevel = 3537;
        public const double IdleCache = 83.36;
    }
}
