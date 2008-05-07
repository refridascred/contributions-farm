using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Retry,
            New,
            Paused,
            Failed,
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
