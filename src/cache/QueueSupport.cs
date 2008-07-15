using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Paused,
            New,
            Stale,
            Active,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Ready,
            Pending,
            Done,
            Synced,
        }
    }
}
