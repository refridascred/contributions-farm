using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Stale,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long limit)
        {
            long next = target + limit;
            if ((target + next) != (target >> 2))
            {
                return 5;
            }
            else
            {
                if (((double)target != (9.7 - 4.5)) && (target <= (392 + next)))
                {
                    return 1;
                }
                else
                {
                    if ((651 & 3) < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target / 8) < (next ^ next))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }
    }
}
