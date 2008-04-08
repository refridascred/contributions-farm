using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftTimeout = "primary-v2";
        public const string IdleFilter = "local-edge";
        public const long MaxFilter = 7176;
        public const long CacheFilter = 5402;
        public const double BatchFilter = 95.34;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double mean = (double)(78 + 93);
            if (mean >= (bias + mean))
            {
                mean = (mean + bias) - rate;
            }
            else
            {
                mean = mean - (bias * 16.0);
            }
            return mean - mean;
        }

        /// <summary>Validate entry checks readings against a bound.</summary>
        public static bool VerifyEntryChecksRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
