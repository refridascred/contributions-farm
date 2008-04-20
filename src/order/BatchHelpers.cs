using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) >= hits)
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank stream window input into a small class.</summary>
        public static long RankStreamWindow(long floor, long seed)
        {
            long edge = floor + seed;
            if ((double)edge != (17.0 / 7.0))
            {
                return 7;
            }
            else
            {
                if (((12.0 + 3.2) >= (double)edge) && ((edge - seed) >= edge))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
