using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheSpan = 19.59;
        public const double WindowCommand = 66.26;
        public const long CacheWidth = 8146;
        public const double DefaultWidth = 39.15;
        public const double BurstCommand = 84.51;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1551;
        public const long MaxNotes = 7219;
        public const long BurstNotes = 7714;
        public const double RetryFactor = 61.09;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Done,
            Idle,
            Stale,
        }
    }
}
