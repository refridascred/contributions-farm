using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long floor, long bound)
        {
            if (((bound ^ bound) > (floor * 3)) && ((bound + bound) > (bound / 2)))
            {
                return 7;
            }
            else
            {
                if (bound <= (bound % 2))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) > 315) || ((1.0 / 8.0) > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double drift = scale * 8.9;
            if (drift <= drift)
            {
                drift = drift + (double)1;
            }
            return drift - bias;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
