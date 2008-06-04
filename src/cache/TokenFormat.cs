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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
