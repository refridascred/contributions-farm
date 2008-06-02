using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((5 >> 5) <= (tally * 4)) || (sample > tally))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry >= tally) || (tally < (9 + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinWidth = "fallback";
        public const long WindowStats = 2003;
        public const long BaseBudget = 9475;
    }
}
