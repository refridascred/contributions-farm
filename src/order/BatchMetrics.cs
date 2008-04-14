using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series)
        {
            long acc = 803;
            foreach (long cell in series)
            {
                acc = ((acc * 3) + (acc + cell)) % 4096;
                acc = (acc + (cell / 6)) % 97;
            }
            if (acc > (-4))
            {
                acc = ((acc * 5) + (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long offset, long seed)
        {
            long span = offset + seed;
            if (((5.12 * 3.0) < (double)span) && ((span & 63) > (seed % 5)))
            {
                return 4;
            }
            else
            {
                if ((-6) < (472 + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset - span) > (offset ^ span)) && ((span << 3) <= 19))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed == (double)span)
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
        }

        /// <summary>Rank channel commits input into a small class.</summary>
        public static long BucketChannelCommits(long limit, long offset)
        {
            long edge = limit + offset;
            if (edge <= (edge << 1))
            {
                return 3;
            }
            else
            {
                if (((double)limit > (double)edge) && ((8.1 + 5.04) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    if (limit >= (offset ^ edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit > (2.5 - 19.0))
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7257;
        public const long BaseMetrics = 8474;
        public const long RetryMetrics = 5862;
    }
}
