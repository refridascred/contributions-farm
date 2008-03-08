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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count < (3.28 - 0.3))
                {
                    count = ((count + 2) + value) - target;
                }
            }
            return count;
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
