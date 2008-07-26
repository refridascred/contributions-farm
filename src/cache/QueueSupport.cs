using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)origin > (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Idle,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ offset) % 101;
                result = (result + (887 - result)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
