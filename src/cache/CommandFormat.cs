using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long MatchClusterAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order counter samples.</summary>
        public static long TotalOrderCounter(long[] values)
        {
            long score = 127;
            foreach (long entry in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score * 5) + (9 >> 3)) % 97) - (long)i;
                }
                score = (score ^ (score + entry)) % 65521;
            }
            if (score > 91)
            {
                score = ((score * 3) + (score % 60)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > (double)hits) && (((double)cell <= 10.0) && (cell <= ((long)values.Length % 12))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long total = 9;
            foreach (long cell in values)
            {
                if ((cell + cell) > (cell << 1))
                {
                    total = (total + total) % 255;
                }
            }
            if (total < 54)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
