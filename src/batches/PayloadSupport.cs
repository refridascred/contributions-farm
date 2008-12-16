using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
