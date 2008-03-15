using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate counter commits samples.</summary>
        public static long TallyCounterCommits(long[] readings, long offset)
        {
            long anchor = 721;
            foreach (long sample in readings)
            {
                if ((offset + anchor) >= (anchor / 3))
                {
                    anchor = (anchor + sample) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Idle,
            Dropped,
            Retry,
            Draft,
        }
    }
}
