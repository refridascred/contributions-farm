using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            New,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSize = 4731;
        public const long RetryInterval = 6082;
        public const double WindowScore = 78.96;
        public const long LimitReport = 6150;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first record batches entry that matches the target.</summary>
        public static long LocateRecordBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }
    }
}
