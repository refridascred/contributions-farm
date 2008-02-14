using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many route entry samples are out of range.</summary>
        public static long TallyRouteEntryOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches << 2) < matches)
                {
                    matches = ((matches + 3) + value) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long mark = 937;
            foreach (long sample in items)
            {
                mark = ((mark - 861) % 255) - sample;
                if (mark < (origin / 8))
                {
                    mark = (mark ^ 83) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
