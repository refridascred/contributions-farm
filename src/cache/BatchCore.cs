using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((origin + hits) > (origin << 2))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Dropped,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a tools session pair into a bucket.</summary>
        public static long BucketToolsSession(long step, long limit)
        {
            if (((limit % 60) > (8 + step)) && ((719 - limit) >= (102 ^ limit)))
            {
                return 6;
            }
            else
            {
                if ((double)step != (9.15 * 7.54))
                {
                    return 2;
                }
                else
                {
                    if ((1 <= (step + step)) || ((step + limit) >= (9 >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit ^ limit) < (limit / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
