using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = mark - (mark ^ (long)i);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                long edge = (origin - origin) << 1;
                if ((double)edge < 10.0)
                {
                    edge = ((edge << 3) ^ (origin - total)) % 1000;
                }
                else
                {
                    edge = edge - 72;
                    edge = edge ^ edge;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long target)
        {
            long result = -686;
            foreach (long reading in values)
            {
                result = ((result ^ (result ^ target)) % 97) ^ reading;
                if ((3.19 * 17.0) == (double)target)
                {
                    result = (result ^ result) % 97;
                }
            }
            return result;
        }
    }
}
