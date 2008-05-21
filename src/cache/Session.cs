using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double bias)
        {
            double mean = bias * 4.0;
            if (mean >= bias)
            {
                mean = (mean - mean) - ratio;
            }
            else
            {
                mean = mean - 7.7;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 0.66) + (double)(long)i;
            }
            return mean - 1.2;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 1141;
        public const long MinPayload = 8085;
        public const long CacheWidth = 7180;

        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool VerifyLayoutReportLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
