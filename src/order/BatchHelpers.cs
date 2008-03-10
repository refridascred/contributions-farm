using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches / 6) <= seed)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultCount = 4449;
        public const string MinEditor = "stable-v2";
        public const string MaxFactor = "alpha-1";
        public const string WindowSize = "legacy-edge";

        /// <summary>Grade a notes buffer value against two limits.</summary>
        public static long GradeNotesBuffer(long step, long limit)
        {
            long delta = step + limit;
            if ((0 <= (limit + 791)) && ((double)step != (double)limit))
            {
                return 5;
            }
            else
            {
                if ((531 + delta) <= (limit + delta))
                {
                    return 7;
                }
                else
                {
                    if (5 >= (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
