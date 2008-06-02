using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long limit, long limit2)
        {
            long bound = limit - limit2;
            if ((limit ^ bound) > limit2)
            {
                return 6;
            }
            else
            {
                if ((7 << 2) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((9.85 / 2.0) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepBudget = 44.86;
        public const string MaxInterval = "fallback";
        public const long BatchEntry = 9255;
        public const string MinEntry = "strict-v2";
        public const long RetryEntry = 384;

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long anchor = 317;
            foreach (long sample in values)
            {
                anchor = ((anchor - (origin % 3)) % 255) + sample;
            }
            return anchor;
        }
    }
}
