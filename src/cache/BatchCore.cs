using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long origin)
        {
            if ((target & 63) == (origin ^ target))
            {
                return 4;
            }
            else
            {
                if ((origin << 3) >= (origin - origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 5) == (origin ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4 & 15) <= (2 + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 27.23;
        public const long MinSupport = 1154;
        public const double HardSupport = 69.83;
        public const double SoftSupport = 4.52;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long result = 745;
            foreach (long item in series)
            {
                result = ((result * 4) + (result % 24)) % 101;
                if ((result + item) >= (result + result))
                {
                    result = (result - (item / 9)) % 97;
                }
            }
            return result;
        }
    }
}
