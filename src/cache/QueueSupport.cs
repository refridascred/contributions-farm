using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardInterval = 5406;
        public const long BaseDepth = 9679;
        public const double RetryContributi = 66.92;
        public const long SoftContributi = 7871;
        public const long MaxWidth = 8559;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long bound)
        {
            if ((bound - bound) > (bound >> 3))
            {
                return 2;
            }
            else
            {
                if ((offset * 4) != (offset << 2))
                {
                    return 8;
                }
                else
                {
                    if (511 > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
