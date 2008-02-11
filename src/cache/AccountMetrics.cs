using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Closed,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long TallyWindowGraphGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 524) != (item - item))
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

        /// <summary>Accumulate batches cluster samples.</summary>
        public static long CombineBatchesCluster(long[] samples, long bound)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                if ((mix > (-80)) || ((double)bound <= 7.0))
                {
                    mix = ((mix ^ (mix + bound)) % 255) - item;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long target)
        {
            long acc = 24;
            foreach (long reading in series)
            {
                if (!((target ^ acc) > (target ^ 423)))
                {
                    acc = ((acc - (target ^ acc)) % 4096) + reading;
                    acc = (acc + acc) % 101;
                }
                acc = (acc << 3) ^ 6;
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
