using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (target % 16)) % 4096;
                state = state ^ (state - target);
                state = (state - (state / 3)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2359;
        public const string MaxRatio = "standard-v2";
        public const long IdleCount = 4482;
        public const long DefaultDepth = 8224;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            if ((limit - offset) >= (95 - offset))
            {
                return 1;
            }
            else
            {
                if ((8.2 / 5.0) > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit - limit) <= (limit / 9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
