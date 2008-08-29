using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double gain = (double)(222 + (-75));
            if (gain > (double)416)
            {
                gain = ((gain + (double)52) + scale) + floor;
            }
            return gain + (double)893;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Ready,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinSize = "latest-edge";
        public const long RetryCache = 5079;
        public const long BatchLevel = 1956;

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 4252;
        public const double CacheAlready = 19.78;
        public const double DefaultAlready = 32.27;
        public const double WindowLevel = 89.73;
        public const long StepRatio = 231;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
