using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool VerifySupportGraphRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double weight = floor * 5.0;
            if (weight < floor)
            {
                weight = weight - (ratio + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (floor / 9.0)) - (double)(long)i;
            }
            return weight - (double)2;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 5741;
        public const long SoftPayload = 3121;
        public const long BasePayload = 7237;
    }
}
