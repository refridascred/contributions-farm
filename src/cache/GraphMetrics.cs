using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2802;
        public const string CacheOrder = "alpha-v2";
        public const double HardTimeout = 0.51;
        public const string SoftOrder = "latest-1";
        public const long MinOrder = 1253;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9377;
        public const double StepChannel = 97.52;
        public const long BurstBudget = 5421;

        /// <summary>Accumulate token order samples.</summary>
        public static long ScoreTokenOrder(long[] series, long target)
        {
            long anchor = 577;
            foreach (long datum in series)
            {
                anchor = (((anchor + (896 * 5)) % 4096) - datum) - target;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] samples)
        {
            long anchor = -69;
            foreach (long item in samples)
            {
                anchor = (anchor + (item >> 4)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double ratio = span;
            if (ratio > bias)
            {
                ratio = ratio + ratio;
            }
            return ratio + (13.0 * 7.8);
        }
    }
}
