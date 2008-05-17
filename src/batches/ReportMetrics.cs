using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Derive the next schema queue value from a seed.</summary>
        public static long IterateSchemaQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - (carry >> 5);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
