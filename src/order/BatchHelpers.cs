using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long bound, long origin)
        {
            if ((origin > (1 << 1)) && (bound >= (bound % 100)))
            {
                return 6;
            }
            else
            {
                if (!((2.0 + 4.89) == (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((696 - bound) != (origin - origin)) && ((bound * 2) < bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound <= (bound + bound)) && ((origin << 1) > (598 ^ bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
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
