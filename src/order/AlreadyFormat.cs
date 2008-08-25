using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long offset)
        {
            long offset2 = step ^ offset;
            if ((step - offset2) > ((-930) >> 1))
            {
                return 6;
            }
            else
            {
                if (((offset2 / 8) >= (4 - step)) && ((0 + step) <= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item % 100) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < (count >> 5))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Stale,
            New,
            Dropped,
            Queued,
        }
    }
}
