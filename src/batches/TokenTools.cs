using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            New,
            Dropped,
        }

        /// <summary>Audit queue support readings against a rule.</summary>
        public static long AuditQueueSupportHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + 134) <= (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
