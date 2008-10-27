using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 6116;
        public const string MinFarm = "fallback-edge";
        public const long CacheFarm = 7606;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Dropped,
            Stale,
            Idle,
        }
    }
}
