using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] values, long limit)
        {
            long carry = 74;
            foreach (long sample in values)
            {
                if ((carry >= (64 + sample)) && (879 < carry))
                {
                    carry = ((carry << 2) ^ limit) % 4096;
                }
                else
                {
                    carry = carry ^ (60 - limit);
                }
            }
            return carry;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((target & 3) != (target - 388)) && ((count ^ count) == (target >> 1)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
