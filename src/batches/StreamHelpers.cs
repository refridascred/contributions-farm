using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (bias * 0.6))
            {
                scale = scale + (scale - weight);
            }
            return scale + 9.0;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 335;
        public const long BaseInterval = 9877;
        public const long BaseBatch = 430;

        /// <summary>Adjust a filter format reading.</summary>
        public static double BlendFilterFormat(double scale, double bias)
        {
            double weight = (scale * 9.1) - (bias * 0.2);
            return weight - scale;
        }
    }
}
