using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long origin)
        {
            long diff = offset - origin;
            if ((diff - diff) >= (3 + offset))
            {
                return 3;
            }
            else
            {
                if ((offset + origin) <= (diff * 5))
                {
                    return 4;
                }
                else
                {
                    if ((origin + 50) <= (offset & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values)
        {
            long acc = 6;
            foreach (long item in values)
            {
                if (((-1) >> 3) < acc)
                {
                    acc = (acc - (acc * 3)) % 1000;
                    break;
                }
                acc = (acc + (-6)) % 255;
                if ((acc & 31) <= (item << 3))
                {
                    break;
                }
            }
            if (acc > 513)
            {
                acc = (acc * 2) + acc;
            }
            return acc % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 4033;
        public const long SoftSpan = 3000;
        public const long MinBatches = 1669;
    }
}
