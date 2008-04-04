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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
