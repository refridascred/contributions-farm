using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 9864;
        public const long MinScore = 2391;
        public const double IdleInterval = 18.67;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long limit)
        {
            if (((target * 4) != (limit & 7)) || ((double)limit != (8.2 + 7.36)))
            {
                return 5;
            }
            else
            {
                if ((4.84 + 4.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of batches metric readings.</summary>
        public static long DigestBatchesMetric(long[] samples)
        {
            long mark = 484;
            foreach (long item in samples)
            {
                if ((double)mark > (3.0 * 1.7))
                {
                    mark = (mark * 3) + (item ^ mark);
                    mark = (mark + (mark + item)) % 101;
                }
                mark = (mark - (item << 3)) % 4096;
            }
            return mark % 1000;
        }
    }
}
