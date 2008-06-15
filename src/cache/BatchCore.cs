using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinBudget = 82.73;
        public const double CacheRatio = 89.82;
        public const string IdleInterval = "local-edge";
        public const long BurstRatio = 4249;
        public const long LimitWindow = 9982;

        /// <summary>Fold a list of batches tools readings.</summary>
        public static long TotalBatchesTools(long[] readings)
        {
            long mix = 428;
            foreach (long entry in readings)
            {
                if (!((6.7 - 1.0) <= (double)mix))
                {
                    mix = (((mix << 2) ^ mix) % 1000) + entry;
                }
            }
            if (mix < 38)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }
    }
}
