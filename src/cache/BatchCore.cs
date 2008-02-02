using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double scale = (bias - 9.0) + (offset / 7.0);
            if (scale < 3.42)
            {
                scale = scale + bias;
            }
            return scale - (bias * 8.0);
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
