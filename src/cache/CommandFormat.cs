using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Label { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            New,
            Paused,
            Idle,
            Retry,
        }
    }
}
