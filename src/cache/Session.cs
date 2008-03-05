using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data)
        {
            long result = 7;
            foreach (long item in data)
            {
                result = result ^ item;
                if (((-7) + item) == (682 / 4))
                {
                    break;
                }
            }
            if (result > 962)
            {
                result = result - (result << 1);
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (8.9 - 1.79))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long seed2)
        {
            if ((seed >> 5) > (seed2 * 3))
            {
                return 5;
            }
            else
            {
                if ((seed - seed2) < (9 + seed2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 9515;
        public const double BurstStream = 12.24;
        public const long SoftBudget = 7761;
        public const long HardTimeout = 416;
    }
}
