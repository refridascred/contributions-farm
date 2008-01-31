using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxFactor = 18.61;
        public const string StepContributi = "alpha-edge";
        public const long BaseContributi = 178;
        public const long HardContributi = 5608;
        public const string IdleBudget = "strict-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 7538;
        public const long StepCache = 4318;
        public const long SoftFactor = 9506;
        public const long LimitCache = 324;

        /// <summary>Look up the position of a batch cluster sample.</summary>
        public static long LocateBatchClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
