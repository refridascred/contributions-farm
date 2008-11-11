using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] values, long bound)
        {
            long total = 3;
            foreach (long sample in values)
            {
                if (!((double)total > 6.8))
                {
                    total = ((total ^ (long)values.Length) - sample) - bound;
                }
            }
            return total;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (4.8 < (double)seed)
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 64.5;
        public const long BurstOrder = 5316;
        public const string SoftOrder = "cached-1";
    }
}
