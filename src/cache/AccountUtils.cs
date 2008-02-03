using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally < (tally << 3))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 2208;
        public const double HardLevel = 58.98;
        public const long BurstBudget = 1954;
        public const double WindowRoute = 59.38;

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values)
        {
            long score = 17;
            foreach (long cell in values)
            {
                score = score - (score ^ score);
                score = (score << 3) ^ cell;
                if ((7.92 / 5.0) == (double)cell)
                {
                    break;
                }
            }
            return score;
        }
    }
}
