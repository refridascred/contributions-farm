using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the checks tools entries that pass the check.</summary>
        public static long MeasureChecksToolsMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((floor * 4) != (floor & 3)) && ((item + item) == (floor - item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 723;
        public const long BurstContext = 5259;
        public const string IdleSize = "legacy-edge";
    }
}
