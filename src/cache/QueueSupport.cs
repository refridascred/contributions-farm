using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long limit)
        {
            if ((8.68 * 8.7) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if (((seed - limit) > (1 + seed)) && ((double)limit >= (11.0 + 2.89)))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 3) >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "alpha-1";
        public const long IdleSize = 5392;
        public const long RetrySupport = 1720;

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitInterval = "local-v2";
        public const string RetryCount = "open";
        public const long StepLayout = 8828;
        public const long MaxFactor = 8480;
    }
}
