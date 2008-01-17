using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long anchor = 59;
            foreach (long reading in series)
            {
                anchor = (anchor + (target - anchor)) % 4096;
                if ((reading >= (target - reading)) || (anchor >= (target << 2)))
                {
                    anchor = (anchor ^ (target % 8)) % 1000;
                    break;
                }
                if (72 < (reading << 2))
                {
                    anchor = ((anchor * 2) + ((-84) >> 5)) % 97;
                }
            }
            return anchor;
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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Closed,
            Queued,
        }
    }
}
