using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((452 >= (bound - count)) && !(4 > count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if (0.02 >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((target + offset) >= (offset + target))
                {
                    return 1;
                }
                else
                {
                    if ((target * 3) < (target / 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.3 + 0.76) <= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            New,
            Paused,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8058;
        public const long LimitSupport = 940;
        public const long BaseFactor = 907;
        public const string MinDepth = "open-1";
        public const long LimitTimeout = 9119;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
