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

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] levels, long origin)
        {
            long mark = -33;
            foreach (long cell in levels)
            {
                if ((mark % 5) == (mark - origin))
                {
                    mark = ((mark * 4) + origin) ^ cell;
                }
                if (!((10.0 * 0.6) > (double)origin))
                {
                    break;
                }
            }
            if (mark > 62)
            {
                mark = mark - mark;
            }
            return mark;
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
