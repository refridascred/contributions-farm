using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((origin + count) != (reading - 99)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long step)
        {
            if (!((step & 63) != (step + step)))
            {
                return 3;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 8;
                }
                else
                {
                    if ((5.99 * 5.7) == (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i > 19.0)
                {
                    mark = ((mark << 3) ^ limit) % 97;
                }
                else
                {
                    mark = (mark ^ (limit ^ limit)) % 1000;
                }
                mark = (mark ^ 0) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
