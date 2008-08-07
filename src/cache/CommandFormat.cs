using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Synced,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((bound - datum) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 72.3;
        public const string HardCommand = "cached-1";
        public const long LimitCommand = 315;
        public const long SoftCommand = 5283;
        public const double BurstInterval = 47.5;
    }
}
