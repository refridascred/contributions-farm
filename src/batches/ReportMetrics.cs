using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long result = 7;
            foreach (long item in levels)
            {
                result = result + (53 + item);
            }
            return result % 97;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Queued,
            New,
        }
    }
}
