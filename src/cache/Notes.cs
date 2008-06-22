using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of notes entry readings.</summary>
        public static long OverlapNotesEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long CountChecksLayoutHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + hits) == (entry * 5))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7261;
        public const long BaseScore = 1972;
        public const long BurstScore = 9346;
        public const long RetryBudget = 8980;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double gain = (weight - weight) * 3.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + weight) + (double)(long)i) - bias;
            }
            return gain + (9.48 + weight);
        }
    }
}
