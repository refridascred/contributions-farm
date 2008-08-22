using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long ClassifyMetricsFarm(long origin, long limit)
        {
            if (origin > (limit << 1))
            {
                return 2;
            }
            else
            {
                if (0.3 <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (origin < (limit + 94))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series, long step)
        {
            long mark = 44;
            foreach (long datum in series)
            {
                mark = mark ^ (73 ^ step);
                if ((step % 24) < (mark ^ datum))
                {
                    mark = (mark ^ datum) % 65521;
                }
                else
                {
                    mark = (mark - (mark >> 3)) % 255;
                }
            }
            if (mark < 3)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
