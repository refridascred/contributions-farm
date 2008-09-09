using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values, long floor)
        {
            long acc = 145;
            foreach (long datum in values)
            {
                if (acc >= (4 % 5))
                {
                    acc = ((acc - (datum + acc)) % 65521) - floor;
                }
                if (acc > datum)
                {
                    break;
                }
            }
            if (acc > 80)
            {
                acc = (acc ^ (acc >> 2)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
