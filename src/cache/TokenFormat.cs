using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7801;
        public const long DefaultStats = 9044;
        public const string IdleStats = "standard-edge";
        public const long DefaultSpan = 8514;

        /// <summary>Audit report tools readings against a rule.</summary>
        public static long CountReportToolsHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - count) != ((long)series.Length >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitSize = 90.27;
        public const double BurstBudget = 36.57;
        public const long WindowAlready = 6414;
        public const long BaseTimeout = 6978;
        public const long HardTimeout = 2917;
    }
}
