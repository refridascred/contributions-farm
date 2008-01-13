using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up support metric samples.</summary>
        public static long OverlapSupportMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series)
        {
            long mark = 927;
            foreach (long reading in series)
            {
                if ((double)reading == (5.0 + 12.0))
                {
                    mark = mark - (reading & 255);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + reading)) % 255;
                }
                if ((reading / 4) > mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
