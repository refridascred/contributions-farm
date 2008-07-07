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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
