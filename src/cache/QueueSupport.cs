using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((67 * 5) > (value % 60))
                {
                    result = (result + (value >> 1)) % 4096;
                }
                else
                {
                    result = result ^ (value % 100);
                }
            }
            if (result > 1)
            {
                result = (result * 2) + 8;
            }
            return result;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
