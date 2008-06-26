using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cluster support reading.</summary>
        public static double SmoothClusterSupport(double gain, double span)
        {
            double rate = gain;
            return (rate - 3.2) + span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowWidth = 785;
        public const long BatchToken = 3318;
        public const long LimitToken = 3532;
        public const string DefaultToken = "local-edge";
        public const string BurstToken = "cached-edge";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen & 7) >= (reading + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
