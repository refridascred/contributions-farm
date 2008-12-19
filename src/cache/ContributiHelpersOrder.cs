using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every support notes entry stays within the limit.</summary>
        public static bool GuardSupportNotesBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 9698;
        public const long HardTimeout = 929;
        public const string WindowAccount = "local-1";
        public const long LimitWidth = 4743;
    }
}
