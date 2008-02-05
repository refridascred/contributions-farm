using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double load = 2.33;
            if (load >= offset)
            {
                load = (load + load) - ratio;
            }
            return load - load;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryLevel = 8080;
        public const double MinInterval = 3.89;
        public const string RetryCount = "primary-v2";
        public const long CacheInterval = 2589;
    }
}
