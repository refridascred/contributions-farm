using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long origin)
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

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long carry = 89;
            foreach (long value in samples)
            {
                if ((900 >> 5) == (36 + value))
                {
                    carry = (carry + (value + value)) % 4096;
                }
                else
                {
                    carry = ((carry * 4) + (37 + value)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long LookupBatchGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7870;
        public const double MaxDepth = 17.83;
        public const long CacheFactor = 1072;
    }
}
