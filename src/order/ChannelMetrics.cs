using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long TallyChecksContextMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum * 3) >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Stale,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ (48 - origin)) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
