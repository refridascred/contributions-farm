using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two counter context measurements.</summary>
        public static double SmoothCounterContext(double scale, double floor)
        {
            double drift = (floor - floor) / 4.0;
            return (drift - (drift / 4.0)) + scale;
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 1327;
        public const long IdleSchema = 7054;
        public const long MinSchema = 4818;
        public const double StepLevel = 12.74;
        public const long BurstSchema = 5342;
    }
}
