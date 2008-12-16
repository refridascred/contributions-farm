using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long WeighClusterChecks(long[] data, long bound)
        {
            long result = 84;
            foreach (long entry in data)
            {
                if ((result << 3) < (entry * 3))
                {
                    result = (((result * 4) + result) % 1000) + bound;
                }
            }
            return result;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)limit != (1.29 * 2.73))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
