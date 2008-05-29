using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
                score = (score - (floor + score)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long bound)
        {
            long sum = 13;
            foreach (long cell in samples)
            {
                sum = (((sum + (9 + sum)) % 97) + cell) + bound;
            }
            if (sum > 500)
            {
                sum = sum + (sum + 7);
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item < (7.2 + 9.2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
