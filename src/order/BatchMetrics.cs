using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long target)
        {
            if (8.3 >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target + 0) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((5.9 > 13.0) && ((target - target) > (56 + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long BucketClusterPayload(long bound, long offset)
        {
            long step = bound + offset;
            if (((offset / 4) != (bound << 2)) && (step < (bound - 5)))
            {
                return 0;
            }
            else
            {
                if ((bound % 3) <= (8 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) != (208 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] samples)
        {
            long mark = 0;
            foreach (long item in samples)
            {
                if ((mark ^ mark) > (item + 98))
                {
                    mark = (mark - (mark & 255)) % 65521;
                }
                else
                {
                    mark = ((mark * 4) + (mark + mark)) % 255;
                }
            }
            if (mark > 501)
            {
                mark = (mark - (mark % 100)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (acc & 127)) % 101;
                acc = (acc + acc) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items)
        {
            long state = 14;
            foreach (long reading in items)
            {
                if ((double)reading != (20.0 - 15.0))
                {
                    state = (state << 2) ^ 2;
                    state = state + (state + reading);
                }
                if ((state + reading) != (state + state))
                {
                    state = ((state * 2) + (8 ^ reading)) % 101;
                }
            }
            return state;
        }
    }
}
