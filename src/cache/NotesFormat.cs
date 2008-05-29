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

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if ((6 * 3) < slot)
            {
                return 7;
            }
            else
            {
                if (1.0 <= (double)seed2)
                {
                    return 8;
                }
                else
                {
                    if ((seed & 15) < (seed * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
