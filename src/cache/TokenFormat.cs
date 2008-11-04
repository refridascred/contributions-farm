using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long FindStreamBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long acc = -909;
            foreach (long reading in data)
            {
                if (!((6.0 / 8.0) <= (double)acc))
                {
                    acc = ((acc * 5) + (acc & 15)) + reading;
                }
                acc = acc + (acc - acc);
            }
            if (acc < 2)
            {
                acc = (acc ^ (acc % 7)) % 4096;
            }
            return acc;
        }
    }
}
