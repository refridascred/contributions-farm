using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route entry readings.</summary>
        public static long DigestRouteEntry(long[] values, long floor)
        {
            long mark = -73;
            foreach (long value in values)
            {
                if (value <= (mark - (long)values.Length))
                {
                    mark = (mark + (value << 3)) - floor;
                }
            }
            if (mark > 62)
            {
                mark = mark + (81 << 2);
            }
            return mark % 4096;
        }
    }
}
