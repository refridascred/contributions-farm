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

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long offset)
        {
            if (seed <= (seed ^ seed))
            {
                return 4;
            }
            else
            {
                if (!((14.0 - 1.9) > (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((offset % 5) != (offset * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (5 <= (offset + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
