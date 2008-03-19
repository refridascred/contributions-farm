using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 3131;
        public const long MaxCount = 9572;
        public const long StepSpan = 5939;
        public const long BaseCounter = 9540;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > (double)sample) && !((sample >> 2) >= (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long target)
        {
            long slot = limit + target;
            if ((target > (slot + slot)) || ((20.0 / 3.0) <= (double)slot))
            {
                return 7;
            }
            else
            {
                if ((27 / 2) > (limit % 5))
                {
                    return 5;
                }
                else
                {
                    if (!(slot >= (slot + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7441;
        public const long WindowFactor = 7818;
        public const long DefaultAlready = 7393;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
