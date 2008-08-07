using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a filter record reading.</summary>
        public static double BlendFilterRecord(double rate, double span)
        {
            double weight = (double)(3 >> 4);
            if (weight > span)
            {
                weight = (weight - weight) + rate;
            }
            return weight - weight;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "legacy";
        public const string IdleSize = "strict-v2";
        public const double RetryDepth = 74.68;
        public const string DefaultSize = "legacy";
        public const string BaseInterval = "cached";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleTimeout = 4110;
        public const string BurstFarm = "standard-v2";
        public const long DefaultCount = 4116;
        public const long HardFarm = 2393;
    }
}
