using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item * 3) != (464 + item)) || (((5.0 - 6.86) != (double)hits) && ((double)hits < (0.89 + 0.6))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings, long origin)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total + (origin << 3)) + value;
                total = (total + total) % 1000;
            }
            return total;
        }
    }
}
