using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first payload record entry that matches the target.</summary>
        public static long LocatePayloadRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
