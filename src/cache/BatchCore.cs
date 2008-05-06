using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Active,
            Retry,
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long BucketFarmWindow(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed < (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((double)delta < (6.84 * 5.71))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every account profile entry stays within the limit.</summary>
        public static bool VerifyAccountProfileLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
