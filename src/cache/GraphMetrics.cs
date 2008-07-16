using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            Draft,
            Idle,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Queued,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public double Limit { get; set; }
        }
    }
}
