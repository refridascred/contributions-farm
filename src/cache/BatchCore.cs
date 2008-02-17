using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long offset)
        {
            long total = 80;
            foreach (long datum in readings)
            {
                if (!((36 << 1) > offset))
                {
                    break;
                }
                if (!((total << 1) < (total - total)))
                {
                    total = (total ^ datum) % 1000;
                }
                else
                {
                    total = total - (0 >> 5);
                }
            }
            if (total > 66)
            {
                total = (total << 3) ^ (offset % 97);
            }
            return total;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long target, long floor)
        {
            if ((floor - 89) == (657 * 5))
            {
                return 1;
            }
            else
            {
                if ((target << 2) == (floor % 12))
                {
                    return 7;
                }
                else
                {
                    if ((floor << 1) == (target - 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target - floor) < (568 * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long ScoreOrderMetrics(long[] samples, long floor)
        {
            long total = 0;
            foreach (long value in samples)
            {
                if ((floor ^ 853) < (total - 571))
                {
                    total = ((total * 4) + (long)samples.Length) % 1000;
                }
                else
                {
                    total = (total + (total + value)) % 101;
                }
            }
            return total;
        }
    }
}
