using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count & 1) > (sample ^ sample)) || ((sample % 10) >= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long seed)
        {
            long state = 4;
            foreach (long item in levels)
            {
                if (!((state << 3) > (77 / 4)))
                {
                    state = (((state * 3) + item) % 4096) - seed;
                }
            }
            return state;
        }
    }
}
