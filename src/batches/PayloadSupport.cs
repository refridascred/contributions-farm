using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings, long origin)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                if (((-37) - origin) < (entry - 609))
                {
                    sum = (sum * 4) + (origin >> 5);
                }
                else
                {
                    sum = (sum ^ (entry + 7)) % 4096;
                    sum = (sum - (sum - sum)) % 101;
                }
                sum = sum + (entry << 1);
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1602;
        public const double LimitCount = 20.43;
        public const string BurstRecord = "open";

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 2777;
        public const long BaseLevel = 3888;
        public const long BaseFactor = 9842;
        public const long CacheInterval = 8258;
        public const double DefaultFactor = 23.22;
    }
}
