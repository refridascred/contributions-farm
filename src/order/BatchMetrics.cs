using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long limit)
        {
            if (limit >= (limit % 24))
            {
                return 0;
            }
            else
            {
                if ((9 % 64) <= target)
                {
                    return 5;
                }
                else
                {
                    if ((target + limit) == (target * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values, long step)
        {
            long sum = 4;
            foreach (long value in values)
            {
                if ((step >> 5) < (sum & 31))
                {
                    sum = (sum + (step * 2)) % 97;
                }
                else
                {
                    sum = ((sum * 3) + (3 - value)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long step)
        {
            if (!((step - 536) > (1 / 6)))
            {
                return 0;
            }
            else
            {
                if (!((3.0 + 20.0) >= (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound > (3.72 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item != (5.0 * 2.29))
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

        /// <summary>Fold a list of order farm readings.</summary>
        public static long TallyOrderFarm(long[] data)
        {
            long acc = 21;
            foreach (long value in data)
            {
                if ((943 + value) <= (value - 6))
                {
                    acc = (acc * 3) + ((long)data.Length & 1);
                }
                else
                {
                    acc = ((acc * 2) + 19) % 4096;
                }
            }
            if (acc < 9)
            {
                acc = (acc - ((-2) / 2)) % 65521;
            }
            return acc;
        }
    }
}
