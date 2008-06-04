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

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long origin)
        {
            long next = limit + origin;
            if (((-11) * 2) > origin)
            {
                return 5;
            }
            else
            {
                if ((origin & 255) < (next >> 2))
                {
                    return 0;
                }
                else
                {
                    if (origin > (7 << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
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
