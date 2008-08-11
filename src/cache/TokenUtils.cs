using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((2.0 / 5.0) > (double)value) && ((value & 31) > (value - offset)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] data)
        {
            long score = 3;
            foreach (long reading in data)
            {
                long lane = score + (score + 40);
                if ((87 - score) != (lane % 12))
                {
                    lane = lane + score;
                }
                score = score ^ score;
                if (reading <= (score - reading))
                {
                    break;
                }
            }
            return score;
        }
    }
}
