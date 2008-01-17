using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = 565;
            foreach (long entry in levels)
            {
                if (!((entry + score) >= entry))
                {
                    score = score - (818 + score);
                }
                if (!((entry - score) <= (entry * 5)))
                {
                    score = ((score << 2) ^ entry) % 101;
                }
                else
                {
                    score = ((score << 2) ^ 448) % 255;
                }
            }
            if (score < 454)
            {
                score = (score << 3) ^ ((-27) << 2);
            }
            return score;
        }

        /// <summary>Measure how many editor order samples are out of range.</summary>
        public static long MeasureEditorOrderMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((double)item != (double)floor))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long floor, long origin)
        {
            long gap = floor + origin;
            if ((double)floor == (3.67 / 6.0))
            {
                return 1;
            }
            else
            {
                if (origin <= (origin ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (origin < (floor << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor + gap) <= (origin & 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache editor samples are out of range.</summary>
        public static long CountCacheEditorMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((19.0 / 6.0) <= (double)bound)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long origin, long seed)
        {
            if (seed >= (9 + origin))
            {
                return 0;
            }
            else
            {
                if (seed > 7)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
