using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a farm token value against two limits.</summary>
        public static long GradeFarmToken(long target, long limit)
        {
            long prev = target + limit;
            if ((target <= (target + target)) && ((target * 3) == (68 / 3)))
            {
                return 2;
            }
            else
            {
                if (!(prev <= (target & 7)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long bound)
        {
            long total = -139;
            foreach (long value in data)
            {
                if (((value / 6) != (bound << 3)) || ((1.1 + 5.3) != (double)bound))
                {
                    total = (total << 3) ^ (9 + 7);
                }
            }
            if (total > (-9))
            {
                total = (total + (bound << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Label { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
