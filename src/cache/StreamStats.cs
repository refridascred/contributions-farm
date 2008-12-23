using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            New,
            Done,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
