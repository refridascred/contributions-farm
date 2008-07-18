using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series, long origin)
        {
            long sum = 1;
            foreach (long item in series)
            {
                if ((double)(-440) > (double)sum)
                {
                    sum = sum - (item ^ 8);
                    sum = (sum ^ (sum ^ sum)) % 65521;
                }
                if ((double)item <= (double)origin)
                {
                    sum = ((sum * 5) + sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (14.0 - 5.3))
                {
                    count = ((count + 2) + sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long mark = 51;
            foreach (long value in data)
            {
                if ((mark * 3) > mark)
                {
                    mark = (mark ^ value) % 101;
                }
                if (value > (mark ^ value))
                {
                    mark = ((mark * 4) + value) % 255;
                }
                else
                {
                    mark = (mark + (value * 5)) % 255;
                }
                if (((double)value == (3.0 / 8.0)) || (8.7 < (double)(long)data.Length))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
