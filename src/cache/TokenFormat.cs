using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardInterval = 60.98;
        public const long BaseBudget = 7088;
        public const long LimitSpan = 2423;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell & 15) == (count / 7))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
