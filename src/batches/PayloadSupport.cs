using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double mean = 2.11;
            if (mean > (double)448)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (mean / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (offset * 5.9)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Retry,
            Done,
            Failed,
        }
    }
}
