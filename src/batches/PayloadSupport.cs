using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Size { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}
