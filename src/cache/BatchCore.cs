using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a record counter value against two limits.</summary>
        public static long ClassifyRecordCounter(long floor, long floor2)
        {
            long diff = floor + floor2;
            if ((floor2 << 1) >= diff)
            {
                return 2;
            }
            else
            {
                if (diff < (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 3) >= (939 % 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Closed,
            Queued,
        }
    }
}
