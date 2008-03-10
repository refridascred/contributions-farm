using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up checks cache samples.</summary>
        public static long MatchChecksCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 26.58;
        public const long StepLayout = 1943;
        public const long WindowLayout = 3711;
        public const long BaseLayout = 3278;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Idle,
            Closed,
            Paused,
            Dropped,
        }
    }
}
