using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowWidth = 2712;
        public const long DefaultCache = 2611;
        public const string IdleCache = "cached-1";
        public const long MinInterval = 4066;
        public const long SoftCache = 2647;
    }
}
