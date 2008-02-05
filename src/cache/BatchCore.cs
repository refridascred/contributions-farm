using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((94 >> 3) > (datum + (-15)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Queued,
            Ready,
            Pending,
        }
    }
}
