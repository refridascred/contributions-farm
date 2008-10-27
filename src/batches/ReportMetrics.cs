using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long score = 8;
            foreach (long sample in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 4) + ((long)i / 8)) % 97;
                    score = ((score << 2) ^ (score + score)) % 101;
                }
                score = (score + (sample % 97)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of batch queue entries.</summary>
        public static long TotalBatchQueue(long[] values)
        {
            long state = 5;
            foreach (long cell in values)
            {
                if (cell <= (state >> 4))
                {
                    state = state - state;
                }
                if ((state + cell) > (cell - cell))
                {
                    long lane = 52 & 255;
                    state = (state ^ (lane + state)) % 101;
                    continue;
                }
                state = (state + cell) % 101;
            }
            return state % 97;
        }
    }
}
