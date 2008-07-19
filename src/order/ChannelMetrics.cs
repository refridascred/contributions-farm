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

        /// <summary>Iterate the stream record series from a seed.</summary>
        public static long IterateStreamRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = total + (offset + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 5) + total) % 255) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

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
