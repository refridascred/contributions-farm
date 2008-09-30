using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
