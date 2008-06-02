using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings)
        {
            long state = 924;
            foreach (long item in readings)
            {
                state = (state + (item % 60)) % 255;
                if ((state * 5) < (item << 3))
                {
                    break;
                }
            }
            if (state > 707)
            {
                state = (state - (state * 2)) % 255;
            }
            return state;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Done,
            Locked,
            Synced,
            New,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
