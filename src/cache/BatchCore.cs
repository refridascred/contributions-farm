using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Failed,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Synced,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Accumulate batches batch samples.</summary>
        public static long CombineBatchesBatch(long[] items, long origin)
        {
            long acc = 173;
            foreach (long reading in items)
            {
                if (((19.0 + 6.0) >= (double)origin) && (reading <= (reading >> 4)))
                {
                    acc = (acc * 5) + reading;
                }
                else
                {
                    acc = ((acc << 2) ^ reading) % 1000;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (origin + origin)) % 4096;
            }
            return acc;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long bound)
        {
            if (floor >= bound)
            {
                return 0;
            }
            else
            {
                if ((4.84 - 9.0) > 3.0)
                {
                    return 4;
                }
                else
                {
                    if (((floor % 97) == (floor + floor)) && ((4.79 - 9.39) <= (6.0 - 1.54)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - floor) != (floor ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
