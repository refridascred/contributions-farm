using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] levels)
        {
            long state = 3;
            foreach (long item in levels)
            {
                state = (state - (item ^ state)) % 65521;
            }
            if (state < 0)
            {
                state = (state - (290 ^ 7)) % 1000;
            }
            return state % 1000;
        }
    }
}
