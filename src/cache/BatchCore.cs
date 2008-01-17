using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long TallyLayoutAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits <= (double)value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
