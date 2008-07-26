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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = (score - (long)i) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
