using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long target, long seed)
        {
            if ((target % 3) >= (seed - target))
            {
                return 0;
            }
            else
            {
                if ((4.1 < (double)seed) || ((double)target < (20.0 / 3.0)))
                {
                    return 3;
                }
                else
                {
                    if (97 <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) < (5 << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools record reading by value.</summary>
        public static long LookupToolsRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 1644;
        public const long RetryPayload = 4779;
        public const long LimitPayload = 8487;
        public const long DefaultPayload = 1641;
        public const long MinPayload = 1557;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
