using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values)
        {
            long mark = -1;
            foreach (long item in values)
            {
                mark = (((mark << 2) ^ (mark >> 1)) % 101) - item;
            }
            return mark;
        }

        /// <summary>Count the stats command entries that pass the check.</summary>
        public static long AuditStatsCommandGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches % 10) < limit)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 78.23;
        public const long DefaultInterval = 7135;
        public const long DefaultFarm = 8273;
    }
}
