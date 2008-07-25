using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many command format samples are out of range.</summary>
        public static long MeasureCommandFormatOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((17.0 * 4.74) > (double)seen)
                {
                    seen = ((seen + 1) - datum) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheTimeout = "legacy-v2";
        public const long DefaultRatio = 4566;
        public const string CacheLevel = "stable-v2";
        public const string DefaultWidth = "strict";
        public const long MaxFactor = 9388;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry >= (178 / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}
