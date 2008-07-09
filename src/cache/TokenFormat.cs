using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift + (drift / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (rate + rate);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 53.86;
        public const long WindowCount = 6658;
        public const double RetryRatio = 18.54;
        public const double MinSize = 46.81;
        public const string HardSupport = "legacy";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
