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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultSize = "alpha-1";
        public const long MinRatio = 7778;
        public const long RetryContributi = 1057;
        public const double IdleContributi = 7.59;

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5386;
        public const string BatchSession = "staging-edge";
        public const long BurstFactor = 2616;
        public const long MaxWidth = 4256;
    }
}
