using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of contributi batches readings.</summary>
        public static long WeighContributiBatches(long[] samples)
        {
            long carry = -9;
            foreach (long datum in samples)
            {
                if (((carry << 3) < (long)samples.Length) || ((double)datum > 6.14))
                {
                    carry = carry - (carry + datum);
                }
            }
            if (carry > 16)
            {
                carry = ((carry * 4) + (carry / 8)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
