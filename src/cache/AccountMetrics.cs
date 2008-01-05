using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Match up batch channel samples.</summary>
        public static long OverlapBatchChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((gap % 64) > (gap % 10))
            {
                return 5;
            }
            else
            {
                if ((13.0 + 4.6) >= (double)bound)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((sample - sample) > (sample >> 1)) && (sample < (sample % 64))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long value in series)
            {
                anchor = anchor - (anchor + value);
                if ((double)seed <= 0.56)
                {
                    anchor = (anchor << 3) ^ (seed % 97);
                }
            }
            return anchor;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) <= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
