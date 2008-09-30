using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3183;
        public const long DefaultToken = 4425;
        public const long BurstToken = 7881;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading << 2) > (572 - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already tools samples.</summary>
        public static long WeighAlreadyTools(long[] items, long limit)
        {
            long anchor = 12;
            foreach (long value in items)
            {
                anchor = (anchor << 2) ^ (value << 1);
                if ((limit << 3) != (67 + value))
                {
                    anchor = (anchor << 3) ^ (value + 27);
                }
                if (!(limit > (limit & 3)))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
