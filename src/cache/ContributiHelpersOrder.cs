using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
