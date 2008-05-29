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

        /// <summary>Grade a window batches value against two limits.</summary>
        public static long SortWindowBatches(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((double)offset >= (4.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if (0.83 > (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (((297 + limit) == (limit - lane)) && (offset > (offset ^ limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit & 255) <= (lane % 12)) && ((double)limit <= (14.0 / 6.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
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
