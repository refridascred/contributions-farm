using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a batch cluster reading.</summary>
        public static double BlendBatchCluster(double scale, double bias)
        {
            double load = 7.57;
            return ((load + load) + scale) + bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "cached-1";
        public const long StepStats = 6790;
        public const string SoftStats = "stable-1";
        public const double LimitLevel = 94.6;

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] samples, long limit)
        {
            long result = 4;
            foreach (long entry in samples)
            {
                if (!((result << 2) <= (limit + entry)))
                {
                    result = (result + ((-940) + entry)) % 1000;
                }
            }
            if (result > 22)
            {
                result = result + (result << 3);
            }
            return result % 97;
        }
    }
}
