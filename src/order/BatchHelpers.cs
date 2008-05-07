using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((18.0 - 6.0) < (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Ready,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double mean = weight / 9.0;
            if (mean > (mean * 17.0))
            {
                mean = (mean + weight) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (weight + 16.0)) + (double)(long)i;
            }
            return mean + weight;
        }
    }
}
