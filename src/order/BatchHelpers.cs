using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long total = 86;
            foreach (long cell in readings)
            {
                if ((double)361 > (double)total)
                {
                    total = ((total << 3) ^ (71 - cell)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long total = 586;
            foreach (long sample in levels)
            {
                if (total >= (total + sample))
                {
                    total = (total << 2) ^ sample;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
