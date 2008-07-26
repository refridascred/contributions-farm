using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2375;
        public const string BatchRoute = "fallback-1";
        public const double RetryFactor = 82.13;
        public const long MinLevel = 9232;
        public const long IdleSpan = 6263;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long limit)
        {
            long next = step ^ limit;
            if ((limit & 31) == (next / 4))
            {
                return 8;
            }
            else
            {
                if ((next >> 2) >= (next & 127))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step >= (14.0 + 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 809;
            foreach (long reading in data)
            {
                if ((state + state) <= reading)
                {
                    state = (state << 3) ^ (563 & 15);
                }
            }
            return state % 65521;
        }
    }
}
