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

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitFactor = 8753;
        public const long SoftCount = 3128;
        public const string CacheRoute = "fallback-v2";
        public const double DefaultInterval = 48.45;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
