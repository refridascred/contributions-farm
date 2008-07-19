using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 8772;
        public const long MinFarm = 9260;
        public const long LimitLevel = 2699;

        /// <summary>Classify a entry payload pair into a bucket.</summary>
        public static long RankEntryPayload(long limit, long step)
        {
            long lane = limit - step;
            if ((double)step >= 3.1)
            {
                return 4;
            }
            else
            {
                if ((step ^ lane) >= (125 >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((step % 64) < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit == (2.95 * 1.43))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
