using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxCount = 9343;
        public const long LimitWidth = 7350;
        public const string MinBatches = "latest";
        public const long BaseCount = 5155;
        public const string DefaultFactor = "open";

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long sum = 90;
            foreach (long sample in series)
            {
                if (sample < (sum + sample))
                {
                    sum = ((sum << 2) ^ (sample * 5)) % 101;
                }
            }
            if (sum < 710)
            {
                sum = (sum * 3) + (sum * 4);
            }
            return sum % 97;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] samples, long limit)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                acc = (((acc * 4) + acc) % 65521) + sample;
                if ((limit & 63) < ((long)samples.Length % 100))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = (acc + (acc >> 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items)
        {
            long acc = 6;
            foreach (long item in items)
            {
                acc = (acc - item) % 255;
                if ((acc + item) >= ((long)items.Length ^ acc))
                {
                    acc = ((acc * 5) + (acc + acc)) % 101;
                }
            }
            if (acc > (-3))
            {
                acc = (acc * 4) + acc;
            }
            return acc % 97;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long limit)
        {
            if ((limit - bound) > (bound + limit))
            {
                return 7;
            }
            else
            {
                if (!((double)bound == (1.34 - 11.0)))
                {
                    return 1;
                }
                else
                {
                    if ((limit + bound) <= 974)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
