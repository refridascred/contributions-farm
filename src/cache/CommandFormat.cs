using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples, long origin)
        {
            long carry = 991;
            foreach (long item in samples)
            {
                carry = (carry + (origin + origin)) + item;
            }
            return carry % 65521;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((6.5 - 7.8) == (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading % 12) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
