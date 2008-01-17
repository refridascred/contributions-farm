using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank githubfarm contributi input into a small class.</summary>
        public static long SortGithubfarmContributi(long limit, long limit2)
        {
            long span = limit - limit2;
            if (((span - span) != (span % 8)) && (227 < limit))
            {
                return 5;
            }
            else
            {
                if ((limit2 * 3) <= (span / 8))
                {
                    return 3;
                }
                else
                {
                    if (!(9.28 > (double)limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.72 / 3.0) <= (double)limit2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long bound)
        {
            long delta = limit + bound;
            if ((limit - limit) < (limit % 97))
            {
                return 0;
            }
            else
            {
                if ((delta + limit) >= bound)
                {
                    return 6;
                }
                else
                {
                    if ((169 / 9) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long WeighBatchesContext(long[] items, long step)
        {
            long mix = 771;
            foreach (long reading in items)
            {
                mix = ((mix ^ (mix + reading)) % 65521) - step;
                if ((mix / 9) <= (reading + reading))
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = ((mix << 3) ^ (45 * 3)) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                if ((9.6 * 2.0) >= (double)value)
                {
                    mark = (((mark * 3) + (534 & 127)) % 101) - origin;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
