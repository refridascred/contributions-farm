using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 95.72;
        public const string BaseQueue = "strict";
        public const long WindowQueue = 631;

        /// <summary>Check that every metric graph entry stays within the limit.</summary>
        public static bool GuardMetricGraphRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
