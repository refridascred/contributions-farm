using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count + reading) <= (reading / 4))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Draft,
            Active,
            Done,
        }
    }
}
