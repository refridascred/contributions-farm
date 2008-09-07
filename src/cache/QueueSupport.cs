using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 3145;
        public const double BatchFilter = 51.09;
        public const long MinWidth = 3044;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxFactor = 5292;
        public const long SoftTools = 305;
        public const long BurstTimeout = 3035;
        public const long BurstTools = 6032;
        public const string MinScore = "strict";

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            if (offset > (seed + offset))
            {
                return 2;
            }
            else
            {
                if ((seed - offset) >= (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
