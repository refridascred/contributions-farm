using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Stale,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Synced,
            Queued,
            Ready,
        }
    }
}
