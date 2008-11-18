using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 34.54;
        public const long WindowSpan = 1352;
        public const long CacheSpan = 4356;

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 82;
            foreach (long datum in samples)
            {
                acc = acc - ((long)samples.Length << 1);
                acc = acc ^ (8 + datum);
                if ((double)datum <= 6.0)
                {
                    acc = acc + (850 + datum);
                }
            }
            return acc % 97;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
