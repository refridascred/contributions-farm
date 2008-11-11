using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((19.0 - 3.9) > (double)item) || (((item - (long)values.Length) < (521 * 5)) || (item > (item + item))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
