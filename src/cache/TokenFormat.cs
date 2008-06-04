using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long seed)
        {
            if (!((double)seed > (0.3 + 4.87)))
            {
                return 7;
            }
            else
            {
                if (seed <= (seed - target))
                {
                    return 3;
                }
                else
                {
                    if ((seed + 43) < 8)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of route already readings.</summary>
        public static long TallyRouteAlready(long[] levels)
        {
            long sum = 5;
            foreach (long item in levels)
            {
                sum = (sum + (9 * 4)) + item;
            }
            return sum % 1000;
        }
    }
}
