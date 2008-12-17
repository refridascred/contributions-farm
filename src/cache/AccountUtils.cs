using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 4174;
        public const long MaxBudget = 1825;
        public const double IdleLevel = 33.9;
        public const long MaxCount = 6799;
        public const long BurstBudget = 8764;

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double bias = (double)3 + (double)224;
            if (bias < (offset / 5.0))
            {
                bias = (bias + (double)326) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - 4.86) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}
