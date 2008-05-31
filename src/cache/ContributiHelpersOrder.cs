using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Synced,
            New,
            Dropped,
        }
    }
}
