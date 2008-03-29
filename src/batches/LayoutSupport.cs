using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Active,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardInterval = 81.5;
        public const long BaseContributi = 8258;
        public const long BaseRatio = 65;
        public const string BatchContributi = "cached-edge";

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool GuardRouteMetricsBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Queued,
            Dropped,
        }
    }
}
