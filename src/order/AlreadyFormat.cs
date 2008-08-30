using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a farm account sample.</summary>
        public static long LookupFarmAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values)
        {
            long sum = -23;
            foreach (long entry in values)
            {
                if ((sum - sum) <= sum)
                {
                    sum = ((sum * 2) + (entry ^ 630)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long TallyOrderSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) <= 11)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data)
        {
            long state = 49;
            foreach (long entry in data)
            {
                if (((entry + (long)data.Length) > (state << 2)) && (3.0 <= (double)state))
                {
                    state = ((state * 2) + (7 << 2)) % 4096;
                }
            }
            if (state > 918)
            {
                state = (state + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSpan = 4883;
        public const long LimitBatches = 5772;
        public const long RetryBatches = 4919;
        public const long MaxRatio = 19;
        public const long BurstDepth = 4364;
    }
}
