using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            if ((68 + offset) >= (offset / 6))
            {
                return 0;
            }
            else
            {
                if ((seed % 8) > (seed >> 5))
                {
                    return 3;
                }
                else
                {
                    if (seed <= (seed - seed))
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

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (target >= (item ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
