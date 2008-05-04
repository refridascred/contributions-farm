using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a farm cache value against two limits.</summary>
        public static long SortFarmCache(long offset, long floor)
        {
            if ((619 ^ offset) == ((-28) << 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) > offset)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Draft,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            New,
            Draft,
            Idle,
            Retry,
        }
    }
}
