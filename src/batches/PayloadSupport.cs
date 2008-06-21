using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] readings)
        {
            long mix = 5;
            foreach (long entry in readings)
            {
                mix = (((mix * 4) + (mix + 366)) % 101) ^ entry;
            }
            return mix;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (origin < (53 ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
