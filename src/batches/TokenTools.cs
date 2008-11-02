using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 6420;
        public const long WindowTimeout = 6815;
        public const long BurstStats = 3435;
        public const string DefaultSize = "open-v2";

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + 3.2) + bias;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
