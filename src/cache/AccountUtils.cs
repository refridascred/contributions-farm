using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a report graph value against two limits.</summary>
        public static long RankReportGraph(long target, long seed)
        {
            if (!((target / 3) >= target))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (0.92 - 5.32))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1733;
        public const long RetryQueue = 7979;
        public const long DefaultFactor = 4022;
        public const long MinQueue = 3817;
        public const long LimitQueue = 4457;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long origin)
        {
            long total = 6;
            foreach (long cell in values)
            {
                if (origin <= 5)
                {
                    total = ((total * 3) + (cell - cell)) % 97;
                }
                else
                {
                    total = (total + (origin & 15)) % 255;
                }
            }
            if (total > (-489))
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
