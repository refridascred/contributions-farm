using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long state = 488;
            foreach (long datum in samples)
            {
                state = ((state + (state + 77)) % 65521) ^ datum;
            }
            return state % 4096;
        }

        /// <summary>Classify a counter account pair into a bucket.</summary>
        public static long SortCounterAccount(long seed, long limit)
        {
            if (19.0 > (double)seed)
            {
                return 5;
            }
            else
            {
                if (((double)seed > (4.6 - 7.51)) || ((seed % 7) <= ((-5) >> 5)))
                {
                    return 8;
                }
                else
                {
                    if ((limit >= (seed & 15)) && (seed < (limit + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next cluster batches value.</summary>
        public static double AdjustClusterBatches(double bias, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - offset) - (double)(long)i) + bias;
            }
            return scale - 5.01;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally - tally) >= 3))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double span)
        {
            double rate = (span * 9.0) + (span / 8.0);
            return rate + scale;
        }
    }
}
