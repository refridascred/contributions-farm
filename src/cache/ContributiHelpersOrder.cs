using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long step, long limit)
        {
            if (((-957) * 5) >= (limit & 31))
            {
                return 2;
            }
            else
            {
                if ((step << 1) != (step & 255))
                {
                    return 5;
                }
                else
                {
                    if ((step / 2) > (step << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 5425;
        public const long RetryCount = 4006;
        public const long CacheReport = 5525;

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5386;
        public const string BatchSession = "staging-edge";
        public const long BurstFactor = 2616;
        public const long MaxWidth = 4256;
    }
}
