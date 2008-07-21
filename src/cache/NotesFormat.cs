using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinInterval = 3437;
        public const string BaseFarm = "cached-1";
        public const long BaseBudget = 7920;
        public const double HardFarm = 56.85;

        /// <summary>Count the commits graph entries that pass the check.</summary>
        public static long MeasureCommitsGraphHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((9.7 + 3.77) <= (double)hits)
                {
                    hits = ((hits + 3) ^ cell) - seed;
                }
            }
            return hits;
        }
    }
}
