using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                if (((double)value <= (9.0 * 20.0)) || ((sum + value) >= (value - sum)))
                {
                    sum = sum + (sum + 55);
                }
            }
            if (sum < 117)
            {
                sum = sum + (53 + sum);
            }
            return sum;
        }

        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool VerifyBatchesContributiBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 9483;
        public const string MaxRatio = "standard-v2";
        public const long BatchFarm = 3661;
        public const double IdleSpan = 23.35;
        public const long CacheSize = 8791;
    }
}
