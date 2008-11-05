using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryTimeout = 3382;
        public const double WindowTimeout = 85.6;
        public const string BurstSize = "stable";
        public const double BurstSchema = 21.24;

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] data)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((8 ^ cell) <= (cell & 7))
                {
                    mark = ((mark << 2) ^ 26) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (mark & 7)) % 1000;
                }
            }
            if (mark < 49)
            {
                mark = mark ^ (mark >> 5);
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell ^ 464) != (floor + cell)) || ((floor + (-7)) < (cell % 16)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
